using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;


namespace FriedVideoGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        public int level = 0;
        LevelRW lvl = new LevelRW();
        private Bitmap bitmap;
        private Control currentTower;
        private Bitmap GameMask;
        private Bitmap GameMaskBitmap;
        private Cursor newCursor;
        private LevelRW.Game LoadedGame;

        private int CurrentWave;

        private List<Point> Points = new List<Point>();
        private List<Control> Towers = new List<Control>();
        private List<Control> Enemies = new List<Control>();

        private List<Point> NewLocs = new List<Point>();
        private List<int> NewIndices = new List<int>();

        private void Game_Load(object sender, EventArgs e)
        {
            //string json = File.ReadAllText("Level_"+level);
            //JsonConvert.DeserializeObject();
            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(1936, 1056);
            GameArea.Size = new Size(1598, 813);
            GameMask = new Bitmap(1598, 813);
            GameMaskBitmap = new Bitmap(1598, 813);
        }

        // Global variable to track the current tower being placed

        #region ----------Tower Handeling-------------
        // Button click event handler for the tower buttons in the shop
        private void TowerButton_Click(object sender, EventArgs e)
        {
            // Cast the sender object to a Button
            Button btn = (Button)sender;

            // Set the currentTower variable to the tower associated with the clicked button
            currentTower = btn;

            // Create a Bitmap object from the image file
            Bitmap customCursor = new Bitmap(btn.BackgroundImage);

            Point pt = new Point(customCursor.Width / 2, customCursor.Height / 2);

            customCursor = customCursor.GetThumbnailImage(btn.Width, btn.Height, null, IntPtr.Zero) as Bitmap;

            // Create a new Cursor object from the Bitmap object
            newCursor = new Cursor(customCursor.GetHicon());

            // Set the Hotspot property of the cursor to the center of the image

            // Set the current cursor to the new cursor
            GameArea.Cursor = newCursor;

        }

        private void GameArea_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button was clicked and a tower is selected
            if (e.Button == MouseButtons.Left && currentTower != null && GameArea.Cursor != DefaultCursor)
            {
                // Create a new PictureBox control to hold the tower image
                PictureBox tower = new PictureBox();

                // Set the tower's image and size
                tower.Image = currentTower.BackgroundImage;
                tower.Size = currentTower.Size;
                tower.Tag = "GameObj";
                tower.SizeMode = PictureBoxSizeMode.StretchImage;

                tower.MouseEnter += Tower_MouseEnter;
                tower.MouseLeave += Tower_MouseLeave;

                // Calculate the center of the tower based on the mouse click coordinates and the tower's size
                int centerX = e.X - tower.Width / 2;
                int centerY = e.Y - tower.Height / 2;

                // Set the tower's location to the center of the mouse click
                tower.Location = new Point(centerX, centerY);

                // Add the tower to the GameArea panel
                GameArea.Controls.Add(tower);
                Towers.Add(tower);
                currentTower = null;
                GameArea.Image = null;
                GameArea.Cursor = DefaultCursor;

            }
        }
        private void GameArea_MouseEnter(object sender, EventArgs e)
        {
            if (currentTower != null)
            {
                GameArea.Image = GameMask;
            }
        }

        private void GameArea_MouseLeave(object sender, EventArgs e)
        {
            if (currentTower != null)
            {
                GameArea.Image = null;
            }
        }
        private void Tower_MouseEnter(object sender, EventArgs e)
        {
            if (currentTower != null)
            {
                GameArea.Cursor = DefaultCursor;
                GameArea.Image = GameMask;
            }
        }

        private void Tower_MouseLeave(object sender, EventArgs e)
        {
            if (currentTower != null)
            {
                GameArea.Cursor = newCursor;
                GameArea.Image = null;
            }
        }

        private void GameArea_MouseMove(object sender, MouseEventArgs e)
        {
            //only show tower if we can place
            if (currentTower != null)
            {
                if (GameMaskBitmap.GetPixel(e.X, e.Y) == Color.FromArgb(255, 255, 0, 0))
                {
                    GameArea.Cursor = DefaultCursor;
                }
                else
                {
                    bool allowd = true;
                    foreach (var twr in Towers)
                    {
                        Point center1 = new Point(twr.Bounds.X + twr.Bounds.Width / 2, twr.Bounds.Y + twr.Bounds.Height / 2);
                        Point center2 = new Point(e.X, e.Y);
                        double a = center1.X - center2.X;
                        double b = center1.Y - center2.Y;
                        double distance = Math.Sqrt(a * a + b * b);
                        double CurrDist = ((currentTower.Width / 2) + (currentTower.Height / 2)) / 2.5;
                        double twrDist = ((twr.Width / 2) + (twr.Height / 2)) / 2.5;
                        if (distance <= (CurrDist + twrDist))
                        {
                            // The towers are within 10 units of each other
                            allowd = false;
                            break;
                        }
                    }


                    if (allowd)
                    {
                        GameArea.Cursor = newCursor;
                    }
                    else
                    {
                        GameArea.Cursor = DefaultCursor;
                    }
                }
            }
            //Bitmap bmp = new Bitmap(GameMask.Width, GameMask.Height);
            //using (Graphics g = Graphics.FromImage(GameMask)) 
            //{
            //    g.DrawImage(GameMask, 0, 0);
            //}
            //bmp.GetPixel();
        }
        #endregion
        #region ----------Saving and loading----------

        private void bttnOpenGame_Click(object sender, EventArgs e)
        {
            LevelRW.Game game = lvl.GetGame();
            if (game != null)
            {
                LoadGame(game);
                LoadedGame = game;
            }
        }
        private void LoadGame(LevelRW.Game game)
        {
            bitmap = new Bitmap(1598, 813);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
            }
            GameArea.BackgroundImage = lvl.Decode(game.Background);
            GameArea.Image = null;
            Image img  = lvl.Decode(game.gameMask);
            GameMaskBitmap = (Bitmap)img;
            //using (Graphics g = Graphics.FromImage(GameMask))
            //{
            //    g.DrawImage(img, 0, 0);
            //}

            bitmap = (Bitmap)lvl.Decode(game.Background);
            // Set the transparency level (0 is fully transparent, 1 is fully opaque)
            float transparency = 0.5f;

            // Create a ColorMatrix to apply the transparency transformation
            ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            {
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, transparency, 0},
                    new float[] {0, 0, 0, 0, 1}
            });

            // Create an ImageAttributes object to apply the ColorMatrix
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            Bitmap bmp = new Bitmap(bitmap.Width, bitmap.Height);
            using (Graphics comb = Graphics.FromImage(bmp))
            {
                comb.DrawImage(bitmap, 0, 0);
                comb.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imageAttributes);
                //comb.DrawImage(Gamemask,0,0);
            }
            GameMask = bmp;



            Points = game.Path.ToList();


            //ClearPoints();

            Points = game.Path.ToList();


            int total = Points.Count();

            for (int i = 0; i < total; i++)
            {
                var point = Points[i];
                MouseEventArgs mea = new MouseEventArgs(MouseButtons.Left, 1, point.X + 10, point.Y + 10, 1);
                //SpawnPoint(mea, false);
            }
            //DrawLines();
        }

        #endregion
        #region -------------Wave System--------------
        private async void StartWave() 
        {
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            SpawnEnemy(LoadedGame.Enemies[0]);
            await Task.Delay(50);
            tmrThink.Start();
            await Task.Delay(50);
            tmrGameTime.Start();

        }
        #endregion
        #region -----------Enemy Handeling------------
        private void SpawnEnemy(LevelRW.Enemy enemy) 
        {
            //ol to hold the tower image
            PictureBox enemyObj = new PictureBox();

            // Set the tower's image and size
            enemyObj.Image = lvl.Decode(enemy.Sprite);
            enemyObj.Size = new Size(50,50);
            enemyObj.Tag = "Enemy,0," + enemy.Speed.ToString();
            enemyObj.SizeMode = PictureBoxSizeMode.StretchImage;
            enemyObj.BackColor = Color.Transparent;

            //start point
            Point e = Points[0];
            // Calculate the center of the tower based on the mouse click coordinates and the tower's size
            int centerX = e.X - enemyObj.Width / 2;
            int centerY = e.Y - enemyObj.Height / 2;

            // Set the tower's location to the center of the mouse click
            enemyObj.Location = new Point(centerX, centerY);

            // Add the tower to the GameArea panel
            GameArea.Controls.Add(enemyObj);
            Enemies.Add(enemyObj);

            //int currentPoint = 0;
            //while (currentPoint < Points.Count)
            //{
            //    Point target = Points[currentPoint];

            //    // Move the enemy towards the target point
            //    enemyObj.Location = new Point(enemyObj.Location.X + (target.X - enemyObj.Location.X) / 2, enemyObj.Location.Y + (target.Y - enemyObj.Location.Y) / 2);

            //    // Check if the enemy has reached the target point
            //    if (enemyObj.Location.X == target.X && enemyObj.Location.Y == target.Y)
            //    {
            //        currentPoint++;
            //    }

            //    // Update the enemy's location on the screen
            //    enemyObj.Update();
            //}
        }

        private void bttnStartWave_Click(object sender, EventArgs e)
        {
            StartWave();
        }

        //private void tmrGameTime_Tick(object sender, EventArgs e)
        //{
        //    foreach (var enemyObj in Enemies)
        //    {
        //        int currentPoint = Int32.Parse(enemyObj.Tag.ToString().Split(',')[1]);
        //        Point target = Points[currentPoint];

        //        // Move the enemy towards the target point
        //        enemyObj.Location = new Point(enemyObj.Location.X + (target.X - enemyObj.Location.X) / 2, enemyObj.Location.Y + (target.Y - enemyObj.Location.Y) / 2);

        //        // Check if the enemy has reached the target point
        //        if (enemyObj.Location.X == target.X && enemyObj.Location.Y == target.Y)
        //        {
        //            currentPoint++;
        //            enemyObj.Tag = "Enemy," + currentPoint.ToString();
        //            if (currentPoint >= Points.Count)
        //            {
        //                MessageBox.Show("Reached its goal");
        //                tmrGameTime.Stop();
        //            }
        //        }

        //        // Update the enemy's location on the screen
        //        enemyObj.Update();
        //    }
        //}
        private void tmrGameTime_Tick(object sender, EventArgs e)
        {
            foreach (var enemyObj in Enemies)
            {
                int currentPoint = Int32.Parse(enemyObj.Tag.ToString().Split(',')[1]);
                if (currentPoint > Points.Count - 1)
                {
                    //return;
                }
                else
                {
                    Point target = Points[currentPoint];

                    // Move the enemy towards the target point
                    enemyObj.Location = new Point(enemyObj.Location.X + (target.X - enemyObj.Location.X) / 2, enemyObj.Location.Y + (target.Y - enemyObj.Location.Y) / 2);

                    // Update the currentPoint variable
                    currentPoint++;
                    enemyObj.Tag = "Enemy," + currentPoint.ToString();

                    // Check if the enemy has reached the target point
                    if (enemyObj.Location.X == target.X && enemyObj.Location.Y == target.Y)
                    {
                        if (currentPoint >= Points.Count)
                        {
                            //tmrGameTime.Stop();
                            //MessageBox.Show("Reached its goal");
                            GameArea.Controls.Remove(enemyObj);
                        }
                    }

                    // Update the enemy's location on the screen
                    enemyObj.Update();
                }
            }
        }
        //private void tmrGameTime_Tick(object sender, EventArgs e)
        //{
        //    foreach (var enemyObj in Enemies)
        //    {
        //        int currentPoint = Int32.Parse(enemyObj.Tag.ToString().Split(',')[1]);
        //        int enemySpeed = Int32.Parse(enemyObj.Tag.ToString().Split(',')[2]);

        //        if (currentPoint > Points.Count - 1)
        //        {
        //            //return;
        //        }
        //        else
        //        {
        //            Point target = Points[currentPoint];

        //            // Calculate the distance between the enemy and the target point
        //            double distance = Math.Sqrt(Math.Pow(target.X - enemyObj.Location.X, 2) + Math.Pow(target.Y - enemyObj.Location.Y, 2));

        //            // Calculate the direction of the enemy's movement
        //            double directionX = (target.X - enemyObj.Location.X) / distance;
        //            double directionY = (target.Y - enemyObj.Location.Y) / distance;

        //            // Calculate the new position of the enemy after it has moved a certain distance towards the target
        //            Point newPosition = new Point(
        //                enemyObj.Location.X + (int)(directionX * enemySpeed),
        //                enemyObj.Location.Y + (int)(directionY * enemySpeed));

        //            // Update the enemy's location
        //            enemyObj.Location = newPosition;

        //            // Update the currentPoint variable
        //            if (enemyObj.Location.X == target.X && enemyObj.Location.Y == target.Y)
        //            {
        //                currentPoint++;
        //                enemyObj.Tag = "Enemy," + currentPoint + "," + enemySpeed;
        //            }

        //            // Check if the enemy has reached the target point
        //            if (currentPoint >= Points.Count)
        //            {
        //                //tmrGameTime.Stop();
        //                //MessageBox.Show("Reached its goal");
        //                GameArea.Controls.Remove(enemyObj);
        //            }

        //            // Update the enemy's location on the screen
        //            enemyObj.Update();
        //        }
        //    }


        //}
        //private void tmrGameTime_Tick(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < Enemies.Count; i++)
        //    {
        //        try
        //        {
        //            string str = Enemies[i].Tag.ToString().Split(',')[2];
        //            Enemies[i].Location = NewLocs[i];
        //            Enemies[i].Tag = "Enemy," + NewIndices[i] + "," + str;
        //            Enemies[i].Update();
        //        }
        //        catch { }
        //    }
        //}

        //private void tmrThink_Tick(object sender, EventArgs e)
        //{
        //    foreach (var enemyObj in Enemies)
        //    {
        //        NewLocs.Clear();
        //        int currentPoint = Int32.Parse(enemyObj.Tag.ToString().Split(',')[1]);
        //        int enemySpeed = Int32.Parse(enemyObj.Tag.ToString().Split(',')[2]);

        //        if (currentPoint > Points.Count - 1)
        //        {
        //            //return;
        //        }
        //        else
        //        {
        //            Point target = Points[currentPoint];

        //            // Calculate the distance between the enemy and the target point
        //            double distance = Math.Sqrt(Math.Pow(target.X - enemyObj.Location.X, 2) + Math.Pow(target.Y - enemyObj.Location.Y, 2));

        //            // Calculate the direction of the enemy's movement
        //            double directionX = (target.X - enemyObj.Location.X) / distance;
        //            double directionY = (target.Y - enemyObj.Location.Y) / distance;

        //            // Calculate the new position of the enemy after it has moved a certain distance towards the target
        //            Point newPosition = new Point(
        //                enemyObj.Location.X + (int)(directionX * enemySpeed),
        //                enemyObj.Location.Y + (int)(directionY * enemySpeed));

        //            // Update the enemy's location
        //            //enemyObj.Location = newPosition;
        //            NewLocs.Add(newPosition);

        //            // Update the currentPoint variable
        //            if (enemyObj.Location.X == target.X && enemyObj.Location.Y == target.Y)
        //            {
        //                currentPoint++;
        //            }
        //                NewIndices.Add(currentPoint);

        //            // Check if the enemy has reached the target point
        //            //if (currentPoint >= Points.Count)
        //            //{
        //            //    //tmrGameTime.Stop();
        //            //    //MessageBox.Show("Reached its goal");
        //            //    GameArea.Controls.Remove(enemyObj);
        //            //}

        //            // Update the enemy's location on the screen
        //            //enemyObj.Update();
        //        }
        //    }
        //}
        //private void tmrGameTime_Tick(object sender, EventArgs e)
        //{
        //    // Create a new thread for updating the enemy positions
        //    Thread enemyMovementThread = new Thread(() =>
        //    {
        //        // Update the positions of the enemies
        //        foreach (var enemyObj in Enemies)
        //        {
        //            int currentPoint = Int32.Parse(enemyObj.Tag.ToString().Split(',')[1]);
        //            int enemySpeed = Int32.Parse(enemyObj.Tag.ToString().Split(',')[2]);

        //            if (currentPoint > Points.Count - 1)
        //            {
        //                //return;
        //            }
        //            else
        //            {
        //                Point target = Points[currentPoint];

        //                // Calculate the distance between the enemy and the target point
        //                double distance = Math.Sqrt(Math.Pow(target.X - enemyObj.Location.X, 2) + Math.Pow(target.Y - enemyObj.Location.Y, 2));

        //                // Calculate the direction of the enemy's movement
        //                double directionX = (target.X - enemyObj.Location.X) / distance;
        //                double directionY = (target.Y - enemyObj.Location.Y) / distance;

        //                // Calculate the new position of the enemy after it has moved a certain distance towards the target
        //                Point newPosition = new Point(
        //                    enemyObj.Location.X + (int)(directionX * enemySpeed),
        //                    enemyObj.Location.Y + (int)(directionY * enemySpeed));

        //                // Update the enemy's location on the UI thread
        //                enemyObj.Invoke((MethodInvoker)delegate
        //                {
        //                    enemyObj.Location = newPosition;
        //                });

        //                // Update the currentPoint variable
        //                if (enemyObj.Location.X == target.X && enemyObj.Location.Y == target.Y)
        //                {
        //                    currentPoint++;
        //                    enemyObj.Tag = "Enemy," + currentPoint + "," + enemySpeed;
        //                }

        //                // Check if the enemy has reached the target point
        //                if (currentPoint >= Points.Count)
        //                {
        //                    //tmrGameTime.Stop();
        //                    //MessageBox.Show("Reached its goal");
        //                    enemyObj.Invoke((MethodInvoker)delegate
        //                    {
        //                        GameArea.Controls.Remove(enemyObj);
        //                    });
        //                }

        //                // Update the enemy's location on the screen
        //                enemyObj.Invoke((MethodInvoker)delegate
        //                {
        //                    enemyObj.Update();
        //                });
        //            }
        //        }
        //    });

        //    // Start the enemy movement thread
        //    enemyMovementThread.Start();


        //}

        #endregion


        //private void LoadGame(LevelRW.Game game)
        //{
        //    GameArea.BackgroundImage = lvl.Decode(game.Background);

        //    bitmap = (Bitmap)lvl.Decode(game.Background);

        //    Points = game.Path.ToList();


        //    ClearPoints();

        //    Points = game.Path.ToList();


        //    int total = Points.Count();

        //    for (int i = 0; i < total; i++)
        //    {
        //        var point = Points[i];
        //        MouseEventArgs mea = new MouseEventArgs(MouseButtons.Left, 1, point.X + 10, point.Y + 10, 1);
        //        SpawnPoint(mea, false);
        //    }
        //    //DrawLines();

        //}
        //private void SpawnPoint(MouseEventArgs e, bool AddToList = true)
        //{
        //    //// Create a new PictureBox control to hold the tower image
        //    //PictureBox Point = new PictureBox();

        //    //// Set the tower's image and size
        //    ////tower.Image = currentTower.BackgroundImage;
        //    //Point.Size = new Size(20, 20);
        //    //Point.SizeMode = PictureBoxSizeMode.StretchImage;
        //    //Point.BackColor = Color.Wheat;
        //    //Point.MouseClick += PointOBJ_MouseClick;

        //    //PointIndex++;

        //    //// Calculate the center of the tower based on the mouse click coordinates and the tower's size
        //    //int centerX = e.X - Point.Width / 2;
        //    //int centerY = e.Y - Point.Height / 2;


        //    //// Set the tower's location to the center of the mouse click
        //    //Point.Location = new Point(centerX, centerY);
        //    //if (custpoint == -1)
        //    //{
        //    //    Point.Tag = "Point," + PointIndex;
        //    //    picbxLevelEditor.Controls.Add(Point);
        //    //    if (AddToList)
        //    //        Points.Add(Point.Location);
        //    //}
        //    //else
        //    //{
        //    //    Point.Tag = "Point," + (custpoint + 1);
        //    //    if (moveMode)
        //    //    {
        //    //        Points.RemoveAt(custpoint);
        //    //        moveMode = false;
        //    //    }

        //    //    picbxLevelEditor.Controls.Add(Point);
        //    //    picbxLevelEditor.Controls.SetChildIndex(Point, custpoint);
        //    //    if (AddToList)
        //    //        Points.Insert(custpoint, Point.Location);
        //    //    custpoint = -1;


        //    //}

        //    //// Add the tower to the GameArea panel
        //    //Drawmode = true;
        //    //picbxLevelEditor.Cursor = DefaultCursor;
        //    ////Console.WriteLine("\nNew:");
        //    ////foreach (var cont in picbxLevelEditor.Controls)
        //    ////{
        //    ////    Console.WriteLine((cont as Control).Tag.ToString());
        //    ////}
        //    //DrawLines();
        //}

        //private void ClearPoints()
        //{
        //    //addVersion();
        //    Points.Clear();
        //    for (int i = 0; i < picbxLevelEditor.Controls.Count; i++)
        //    {
        //        Control cont = (Control)picbxLevelEditor.Controls[i];
        //        if (cont.Tag.ToString().Contains("Point"))
        //        {
        //            picbxLevelEditor.Controls.RemoveAt(i);
        //            i--;
        //        }
        //    }
        //    picbxLevelEditor.Image = (Image)bitmap;
        //}


        //public class Tower
        //{
        //    // Position of the tower
        //    public Point Position { get; set; }

        //    // Range of the tower
        //    public int Range { get; set; }

        //    // Damage of the tower
        //    public int Damage { get; set; }

        //    // Image of the tower
        //    public Bitmap Image { get; set; }

        //    // Method to place the tower at a given position
        //    public void Place(Point position)
        //    {
        //        // Set the tower's position
        //        Position = position;

        //        // Add the tower to the game's list of towers
        //        Game.Towers.Add(this);
        //    }
        //}


        //public class Level 
        //{
        //    public Image Background { get; set; }
        //    public List<Point> pointers { get; set; }

        //}
    }
}
