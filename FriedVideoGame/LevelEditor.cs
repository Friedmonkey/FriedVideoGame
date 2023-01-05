using FriedVideoGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FriedVideoGame
{
    public partial class LevelEditor : Form
    {
        // The current color that will be used to draw on the picture box
        private Color _penColor = Color.Black;
        private int _penSize = 22;
        //private Pen semiTransPen = new Pen(Color.FromArgb(128, 255, 0, 0), 22);

        bool Drawmode = true;
        bool moveMode = false;
        bool FullScreen = false;
        private Bitmap bitmap;
        private Bitmap Pointsbitmap;
        LevelRW lvl = new LevelRW();

        // The image that will be used as the background for the level
        private Image _levelImage;

        private List<LevelRW.Game> Versions = new List<LevelRW.Game>();
        private int CurrentVersion = 0;
        private bool Swapping = false;
        int oldWidth, oldHeight;

        private bool GameMaskMode = false;
        private Bitmap Gamemask;



        // A list of points that represents the path that enemies will follow
        private List<Point> Points = new List<Point>();
        //point name
        private int PointIndex = 0;

        private int custpoint = -1;

        private List<LevelRW.Enemy> enemies = new List<LevelRW.Enemy>();

        public LevelEditor()
        {
            string encoded = lvl.Encode(Resources.Baloonpng);
            enemies.Add(new LevelRW.Enemy() { Sprite = encoded, Speed = 2 });
            //enemies.Add(new LevelRW.Enemy() { Sprite = encoded, Speed = 2 });
            //enemies.Add(new LevelRW.Enemy() { Sprite = encoded, Speed = 2 });
            //enemies.Add(new LevelRW.Enemy() { Sprite = encoded, Speed = 2 });
            //enemies.Add(new LevelRW.Enemy() { Sprite = encoded, Speed = 2 });

            InitializeComponent();
            picbxLevelEditor.BackColor = Color.White;
            picbxLevelEditor.SizeMode = PictureBoxSizeMode.Zoom;

            bttnBlack.BackColor = Color.Black;
            bttnGray.BackColor = Color.Gray;
            bttnBlue.BackColor = Color.Blue;
            bttnWhite.BackColor = Color.White;
            bttnBrown.BackColor = Color.Sienna;
            bttnLightBlue.BackColor = Color.LightBlue;
            bttnYellow.BackColor = Color.Yellow;


            bttnLightGreen.BackColor = Color.YellowGreen;
            bttnGreen.BackColor = Color.Green;
            bttnDarkGreen.BackColor = Color.DarkOliveGreen;

            bttnBlack.Text = "Black";
            bttnGray.Text = "Gray";
            bttnBlue.Text = "Blue";
            bttnWhite.Text = "White";
            bttnBrown.Text = "Brown";
            bttnLightBlue.Text = "L Blue";
            bttnYellow.Text = "Yellow";

            bttnLightGreen.Text = "L Green";
            bttnGreen.Text = "Green";
            bttnDarkGreen.Text = "D Green";

            bttnBlack.ForeColor = Color.FromArgb(bttnBlack.BackColor.ToArgb() ^ 0xffffff);
            bttnGray.ForeColor = Color.FromArgb(bttnGray.BackColor.ToArgb() ^ 0xffffff);
            bttnBlue.ForeColor = Color.FromArgb(bttnBlue.BackColor.ToArgb() ^ 0xffffff);
            bttnWhite.ForeColor = Color.FromArgb(bttnWhite.BackColor.ToArgb() ^ 0xffffff);
            bttnBrown.ForeColor = Color.FromArgb(bttnWhite.BackColor.ToArgb() ^ 0xffffff);
            bttnYellow.ForeColor = Color.FromArgb(bttnYellow.BackColor.ToArgb() ^ 0xffffff);
            bttnLightBlue.ForeColor = Color.FromArgb(bttnLightBlue.BackColor.ToArgb() ^ 0xffffff);

            bttnLightGreen.ForeColor = Color.FromArgb(bttnLightGreen.BackColor.ToArgb() ^ 0xffffff);
            bttnGreen.ForeColor = Color.FromArgb(bttnGreen.BackColor.ToArgb() ^ 0xffffff);
            bttnDarkGreen.ForeColor = Color.FromArgb(bttnDarkGreen.BackColor.ToArgb() ^ 0xffffff);


            bttnGray.ForeColor = Color.Black;

            //bitmap = new Bitmap(picbxLevelEditor.Width, picbxLevelEditor.Height);
            bitmap = new Bitmap(1598, 813);
            Gamemask = new Bitmap(1598, 813);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.FromArgb(0,255,0,0));
            }
            Pointsbitmap = new Bitmap(bitmap.Width,bitmap.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
            }
            picbxLevelEditor.Image = bitmap;


            //oldWidth = picbxLevelEditor.Width+0;
            //oldHeight = picbxLevelEditor.Height+0;

            oldWidth = 656;
            oldHeight = 363;
            ////addVersion();
            //Swapping = true;
            //LoadGame(Versions[CurrentVersion - 1]);
            //Swapping = false;
            //CurrentVersion--;
            //lblVersion.Text = CurrentVersion + "";
            //addVersion();
            //CurrentVersion--;
            Fullscreen(true);




        }

        #region ---------Pen Size and colour----------
        private void bttnColour_Click(object sender, EventArgs e)
        {
            // Set the pen color to black
            _penColor = (sender as Button).BackColor;
        }
        private void bttnSize_Click(object sender, EventArgs e)
        {
            // Set the pen color to black
            _penSize = Convert.ToInt32(((sender as Button).Font.Size-19)*5);
        }
        #endregion

        #region ---------------Drawing----------------
        private void picbxLevelEditor_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                if (Drawmode)
                {
                    Draw(e);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                if (Drawmode) 
                {
                    if (GameMaskMode)
                    {
                        Draw(e,true);
                    }
                }
            }
        }
        private void picbxLevelEditor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Drawmode) 
                {
                    addVersion();
                }
            }
        }
        private void picbxLevelEditor_MouseUp(object sender, MouseEventArgs e)
        {
            if (Points.Count > 0)
                DrawLines();
            if (GameMaskMode) 
            {
                DrawMask();
            }
        }


        //private void Draw(MouseEventArgs e)
        //{
        //    using (Graphics g = Graphics.FromImage(bitmap))
        //    {
        //        using (Pen pen = new Pen(_penColor, _penSize))
        //        {
        //            g.FillEllipse(pen.Brush, e.Location.X - (_penSize / 2), e.Location.Y - (_penSize / 2), _penSize, _penSize);
        //            //g.DrawImage(Pointsbitmap,0,0);
        //        }
        //    }
        //    picbxLevelEditor.Image = bitmap;
        //    if (Points.Count > 0)
        //        DrawLines();
        //}
        private void Draw(MouseEventArgs e,bool remove = false)
        {
            if (GameMaskMode)
            {
                using (Graphics g = Graphics.FromImage(Gamemask))
                {
                    if (remove)
                    {
                        // Set the compositing mode to SourceCopy to allow drawing over the image
                        g.CompositingMode = CompositingMode.SourceCopy;

                        // Get the location and size of the circle
                        Point pt = newP(e.Location);
                        int x = pt.X;
                        int y = pt.Y;
                        int width = _penSize;
                        int height = _penSize;

                        // Draw a transparent circle over the area you want to remove
                        using (Pen pen = new Pen(Color.FromArgb(0, 0, 0, 0), _penSize))
                        {
                            g.FillEllipse(pen.Brush, x - (width / 2), y - (height / 2), width, height);
                        }
                    }
                    else
                    {

                        using (Pen pen = new Pen(Color.Red, _penSize))
                        {
                            Point pt = newP(e.Location);
                            int x = pt.X;
                            int y = pt.Y;

                            //Console.WriteLine("Mouse coordinates: ({0}, {1})", e.Location.X, e.Location.Y);
                            //Console.WriteLine("Calculated coordinates: ({0}, {1})", x, y);

                            g.FillEllipse(pen.Brush, x - (_penSize / 2), y - (_penSize / 2), _penSize, _penSize);
                            //g.DrawImage(Pointsbitmap,0,0);
                        }
                    }
                }
                picbxLevelEditor.Image = (Image)Gamemask;
            }
            else
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(_penColor, _penSize))
                    {
                        Point pt = newP(e.Location);
                        int x = pt.X;
                        int y = pt.Y;

                        //Console.WriteLine("Mouse coordinates: ({0}, {1})", e.Location.X, e.Location.Y);
                        //Console.WriteLine("Calculated coordinates: ({0}, {1})", x, y);

                        g.FillEllipse(pen.Brush, x - (_penSize / 2), y - (_penSize / 2), _penSize, _penSize);
                        //g.DrawImage(Pointsbitmap,0,0);
                    }
                }
                picbxLevelEditor.Image = bitmap;
            }
        }


        private void bttnClear_Click(object sender, EventArgs e)
        {
            addVersion();
            //bitmap = new Bitmap(picbxLevelEditor.Width, picbxLevelEditor.Height);
            bitmap = new Bitmap(1598, 813);

            using (Graphics g = Graphics.FromImage(bitmap)) 
            {
                g.Clear(Color.White);
            }
            picbxLevelEditor.Image = bitmap;

            ClearPoints();
        }

        private void bttnFill_Click(object sender, EventArgs e)
        {
            addVersion();
            //bitmap = new Bitmap(picbxLevelEditor.Width, picbxLevelEditor.Height);
            bitmap = new Bitmap(1598, 813);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(_penColor);
            }
            picbxLevelEditor.Image = bitmap;
            DrawLines();
        }
        private void picbxLevelEditor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Drawmode)
                {
                    Draw(e);
                }
                else
                {
                    addVersion();
                    if (FullScreen)
                    {
                        SpawnPoint(e);
                    }
                    else
                    {
                        SpawnPoint(e, true, true);
                    }
                }
            }
        }
        #endregion

        #region ---------------Points-----------------
        private void SpawnPoint(MouseEventArgs e, bool AddToList = true, bool downscale = false) 
        {
            // Create a new PictureBox control to hold the tower image
            PictureBox Point = new PictureBox();

            // Set the tower's image and size
            Point.Size = new Size(30, 30);
            Point.SizeMode = PictureBoxSizeMode.StretchImage;
            Point.BackColor = Color.Wheat;
            Point.MouseClick += PointOBJ_MouseClick;

            PointIndex++;
            int centerX;
            int centerY;
            Point ListPT;
            Point PhysicalPT;

            centerX = e.X - Point.Width / 2;
            centerY = e.Y - Point.Height / 2;
            PhysicalPT = new Point(centerX, centerY);
            if (!downscale)
            {
                // Calculate the center of the tower based on the mouse click coordinates and the tower's size
                centerX = e.X - Point.Width / 2;
                centerY = e.Y - Point.Height / 2;
                ListPT = new Point(centerX,centerY);
            }
            else
            {
                Point pt = newP(e.Location);
                centerX = pt.X - Point.Width / 2;
                centerY = pt.Y - Point.Height / 2;
                ListPT = new Point(centerX, centerY);
            }


            // Set the tower's location to the center of the mouse click
            Point.Location = PhysicalPT;

            if (custpoint == -1)
            {
                Point.Tag = "Point," + PointIndex;
                picbxLevelEditor.Controls.Add(Point);
                if (AddToList)
                    Points.Add(ListPT);
            }
            else 
            {
                Point.Tag = "Point," + (custpoint+1);
                if (moveMode) 
                {
                    Points.RemoveAt(custpoint);
                    moveMode = false;
                }

                picbxLevelEditor.Controls.Add(Point);
                picbxLevelEditor.Controls.SetChildIndex(Point,custpoint);
                if (AddToList)
                    Points.Insert(custpoint, ListPT);
                custpoint = -1;


            }

            // Add the tower to the GameArea panel
            Drawmode = true;
            picbxLevelEditor.Cursor = DefaultCursor;
            DrawLines();
        }

        private void ClearPoints()
        {

            Points.Clear();
            for (int i = 0; i < picbxLevelEditor.Controls.Count; i++)
            {
                Control cont = (Control)picbxLevelEditor.Controls[i];
                if (cont.Tag.ToString().Contains("Point"))
                {
                    picbxLevelEditor.Controls.RemoveAt(i);
                    i--;
                }
            }
            picbxLevelEditor.Image = (Image)bitmap;
        }

        private void PointOBJ_MouseClick(object sender, MouseEventArgs e) 
        {
            Control pic = (sender as Control);
            int pointIndex = 0;
            for (int i = 0; i < picbxLevelEditor.Controls.Count; i++)
            {
                if (picbxLevelEditor.Controls[i] == pic)
                {
                    pointIndex = i;
                    break;
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                //Points.RemoveAt(pointIndex);
                picbxLevelEditor.Controls.RemoveAt(pointIndex);

                moveMode = true;
                Drawmode = false;
                custpoint = pointIndex;
                // Create a Bitmap with the desired dimensions

                Bitmap customCursor = new Bitmap(20, 20);

                // Create a Graphics object for the Bitmap
                using (Graphics g = Graphics.FromImage(customCursor))
                {
                    // Fill the Bitmap with white
                    g.Clear(Color.Wheat);
                }

                // Set the current cursor to the new cursor
                picbxLevelEditor.Cursor = new Cursor(customCursor.GetHicon());
            }
            if (e.Button == MouseButtons.Right) 
            {
                addVersion();
                Points.RemoveAt(pointIndex);
                picbxLevelEditor.Controls.RemoveAt(pointIndex);
            }
            if (e.Button == MouseButtons.Middle) 
            {

                Drawmode = false;
                custpoint = pointIndex;
                // Create a Bitmap with the desired dimensions

                Bitmap customCursor = new Bitmap(20, 20);

                // Create a Graphics object for the Bitmap
                using (Graphics g = Graphics.FromImage(customCursor))
                {
                    // Fill the Bitmap with white
                    g.Clear(Color.Wheat);
                }

                // Set the current cursor to the new cursor
                picbxLevelEditor.Cursor = new Cursor(customCursor.GetHicon());
            }
            DrawLines();
            //pic.Click -= PointOBJ_Click;
        }

        //this is where i draw the line🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣🤣
        private void DrawLines() 
        {
            if (Points.Count < 1)
                return;
            if (!FullScreen) 
            {
                picbxLevelEditor.Image = bitmap;
                return;
            }
            Pointsbitmap = new Bitmap(bitmap.Width,bitmap.Height);
            using (Graphics g = Graphics.FromImage(Pointsbitmap))
            {
                using (Pen pen = new Pen(Color.Wheat, 7))
                {
                    g.DrawImage(bitmap,0,0);
                    Point _prevPoint = Points[0];

                    foreach (var point in Points)
                    {
                        g.DrawLine(pen, _prevPoint.X+10,_prevPoint.Y+10,point.X+10,point.Y+10);
                        _prevPoint = point; 
                    }
                }
            }
            picbxLevelEditor.Image = Pointsbitmap;
        }

        private void bttnPoint_Click(object sender, EventArgs e)
        {
            if (!FullScreen)
            {
                MessageBox.Show("Points can only be added or edited in full screen");
                return;
            }
            Drawmode = false;
            // Create a Bitmap with the desired dimensions

            Bitmap customCursor = new Bitmap(20, 20);

            // Create a Graphics object for the Bitmap
            using (Graphics g = Graphics.FromImage(customCursor))
            {
                // Fill the Bitmap with white
                g.Clear(Color.Wheat);
            }

            // Set the current cursor to the new cursor
            picbxLevelEditor.Cursor = new Cursor(customCursor.GetHicon());
        }
        private void bttnClearPoints_Click(object sender, EventArgs e)
        {
            addVersion();
            ClearPoints();
        }
        #endregion

        #region ----------Saving and loading----------
        private void LoadGame(LevelRW.Game game) 
        {
            picbxLevelEditor.Image = lvl.Decode(game.Background);

            bitmap = (Bitmap)lvl.Decode(game.Background);

            Points = game.Path.ToList();


            ClearPoints();

            Points = game.Path.ToList();


            int total = Points.Count();

            for (int i = 0; i < total; i++)
            {
                var point = Points[i];
                MouseEventArgs mea = new MouseEventArgs(MouseButtons.Left, 1, point.X + 10, point.Y + 10, 1);
                    SpawnPoint(mea, false);
                if (!FullScreen)
                {
                    foreach (Control ptr in picbxLevelEditor.Controls)
                    {
                        if (ptr.Tag.ToString().Contains("Point"))
                        {
                            ptr.Visible = false;
                        }
                    }
                }
            }
            DrawLines();
            Gamemask = (Bitmap)lvl.Decode(game.gameMask);
            GameMaskMode = !game.gameMaskMode;
            ToggleGameMask();
        }
        private LevelRW.Game SaveGame() 
        {
            LevelRW.Game game = new LevelRW.Game()
            {
                Background = lvl.Encode((Image)bitmap),
                Path = Points.ToList(),
                Enemies = enemies,
                gameMaskMode = GameMaskMode,
                gameMask = lvl.Encode((Image)Gamemask)
            };
            return game;
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            LevelRW.Game game = SaveGame();
            lvl.SaveGame(game);
        }

        private void bttnLoad_Click(object sender, EventArgs e)
        {
            LevelRW.Game game = lvl.GetGame();
            if (game != null) 
            {
                LoadGame(game);
            }
        }
        #endregion

        #region -----------Version Control------------

        public void addVersion() 
        {
            if (!Swapping) 
            {
                //if you are modyfiying a older version
                if (CurrentVersion < Versions.Count)
                {
                    //CurrentVersion++;
                    Versions.RemoveRange(CurrentVersion , Versions.Count - CurrentVersion);
                    lstbxVersions.Items.Clear();

                    for (int i = 0; i < CurrentVersion; i++)
                    {
                        lstbxVersions.Items.Add((i+1) + " Version");
                    }
                    CurrentVersion = Versions.Count;

                }
                LevelRW.Game game = SaveGame();
                Versions.Add(game);
                CurrentVersion++;
                lstbxVersions.Items.Add(CurrentVersion+" Version");
                lblVersion.Text = CurrentVersion + "";
            }
        }

        private void bttnUndo_Click(object sender, EventArgs e)
        {
            if (CurrentVersion > 0) 
            {
                if (CurrentVersion == Versions.Count)
                {
                    addVersion();
                    //CurrentVersion--;
                    CurrentVersion--;
                }
                Swapping = true;
                LoadGame(Versions[CurrentVersion - 1]);
                Swapping = false;
                CurrentVersion--;
                lblVersion.Text = CurrentVersion + "";
            }
        }

        private void bttnRedo_Click(object sender, EventArgs e)
        {
            if (Versions.Count-1 > CurrentVersion)
            {
                Swapping = true;
                LoadGame(Versions[CurrentVersion+1]);
                Swapping = false;
                CurrentVersion++;
                lblVersion.Text = CurrentVersion + "";
            }
        }
        #endregion

        #region --------------Responsive--------------
        private Point newP(Point input)
        {
            int x = input.X;
            int y = input.Y;

            int originalWidth = bitmap.Width;
            int originalHeight = bitmap.Height;

            int currentWidth = picbxLevelEditor.ClientSize.Width;
            int currentHeight = picbxLevelEditor.ClientSize.Height;

            float scaleX = (float)currentWidth / (float)originalWidth;
            float scaleY = (float)currentHeight / (float)originalHeight;

            x = (int)(((float)x / scaleX) * 1f);
            y = (int)(((float)y / scaleY) * 1f);

            return new Point(x, y);
        }
        private void bttnScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                Fullscreen(true);
            }
            else 
            {
                NormalScreen(true);
            }
        }
        private void Fullscreen(bool ActionOnly = false) 
        {
            if (!ActionOnly) 
            {
                addVersion();
            }
            FullScreen = true;
            this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(1936, 1056);
            picbxLevelEditor.Size = new Size(1598, 813);
            foreach (Control point in picbxLevelEditor.Controls)
            {
                if (point.Tag.ToString().Contains("Point"))
                {
                    point.Visible = true;
                }
            }
            DrawLines();
        }
        private void NormalScreen(bool ActionOnly = false) 
        {
            if (!ActionOnly)
            {
                addVersion();
            }
            FullScreen = false;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(818, 513);
            picbxLevelEditor.Size = new Size(499, 254);
            foreach (Control point in picbxLevelEditor.Controls)
            {
                if (point.Tag.ToString().Contains("Point"))
                {
                    point.Visible = false;
                }
            }
            DrawLines();
        }
        #endregion

        #region -----------Data Protection------------
        private void bttnNew_Click(object sender, EventArgs e)
        {
            if (Versions.Count > 10)
            {
                DialogResult dr = MessageBox.Show("You want to quit and heavent saved yet, do you want to save now?", "unsaved progress detected!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    this.FormClosing -= LevelEditor_FormClosing;

                    Application.Restart();
                }
                else if (dr == DialogResult.Yes)
                {
                    LevelRW.Game game = SaveGame();
                    lvl.SaveGame(game);
                }
            }
            else 
            {
                this.FormClosing -= LevelEditor_FormClosing;
                Application.Restart();
            }
        }

        private void LevelEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Versions.Count > 10)
            {
                DialogResult dr = MessageBox.Show("You want to quit and heavent saved yet, do you want to save now?", "unsaved progress detected!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    //Environment.Exit(0);
                }
                else if (dr == DialogResult.Yes)
                {
                    LevelRW.Game game = SaveGame();
                    lvl.SaveGame(game);
                }
            }
            else
            {
                //Environment.Exit(0);
            }
        }


        private void bttnPlay_Click(object sender, EventArgs e)
        {
            if (Versions.Count > 10)
            {
                DialogResult dr = MessageBox.Show("You want to quit and heavent saved yet, do you want to save now?", "unsaved progress detected!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    LevelRW.Game game = SaveGame();
                    lvl.SaveGame(game);
                    return;
                }
                else if (dr == DialogResult.Cancel) 
                {
                    return;
                }
            }
            this.FormClosing -= LevelEditor_FormClosing;
            this.Hide();
            GameForm form = new GameForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        #endregion

        #region --------------Game mask---------------
        private void ToggleGameMask() 
        {
            //GameMaskMode = !GameMaskMode;
            addVersion();
            if (GameMaskMode)
            {
                GameMaskMode = false;

                picbxLevelEditor.Image = (Image)bitmap;
                DrawLines();

                bttnDarkGreen.Enabled = true;
                bttnGreen.Enabled = true;
                bttnLightGreen.Enabled = true;
                bttnYellow.Enabled = true;
                bttnBlue.Enabled = true;
                bttnLightBlue.Enabled = true;
                bttnGray.Enabled = true;
                bttnWhite.Enabled = true;
                bttnBlack.Enabled = true;
                bttnBrown.Enabled = true;
            }
            else
            {
                GameMaskMode = true;

                picbxLevelEditor.BackgroundImage = picbxLevelEditor.Image;
                DrawMask();

                bttnDarkGreen.Enabled = false;
                bttnGreen.Enabled = false;
                bttnLightGreen.Enabled = false;
                bttnYellow.Enabled = false;
                bttnBlue.Enabled = false;
                bttnLightBlue.Enabled = false;
                bttnGray.Enabled = false;
                bttnWhite.Enabled = false;
                bttnBlack.Enabled = false;
                bttnBrown.Enabled = false;

            }
        }

        private void bttnClearGameMask_Click(object sender, EventArgs e)
        {
            Gamemask = new Bitmap(1598, 813);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.FromArgb(0, 255, 0, 0));
            }
            if (GameMaskMode)
            {
                picbxLevelEditor.Image = (Image)bitmap;
                DrawLines();
            }
        }


        private void bttnInvertGamemask_Click(object sender, EventArgs e)
        {
            addVersion();
            //// Create a ColorMatrix to invert the alpha channel
            //ColorMatrix colorMatrix = new ColorMatrix(new float[][]
            //{
            //    new float[] {1, 0, 0, 0, 0},
            //    new float[] {0, 1, 0, 0, 0},
            //    new float[] {0, 0, 1, 0, 0},
            //    new float[] {0, 0, 0, -1, 1},
            //    new float[] {0, 0, 0, 0, 1}
            //});

            //// Create an ImageAttributes object to apply the ColorMatrix
            //ImageAttributes imageAttributes = new ImageAttributes();
            //imageAttributes.SetColorMatrix(colorMatrix);

            //// Create a new bitmap to hold the inverted image
            //Bitmap invertedBmp = new Bitmap(Gamemask.Width, Gamemask.Height);

            //// Draw the inverted image onto the new bitmap
            //using (Graphics g = Graphics.FromImage(invertedBmp))
            //{
            //    g.DrawImage(Gamemask, new Rectangle(0, 0, Gamemask.Width, Gamemask.Height), 0, 0, Gamemask.Width, Gamemask.Height, GraphicsUnit.Pixel, imageAttributes);
            //}

            //// Use the inverted image as needed
            ////picbxLevelEditor.Image = (Image)invertedBmp;
            ///
            Bitmap bmp = new Bitmap(Gamemask);// your bitmap object
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    if (pixelColor.A == 0)
                    {
                        // Change transparent pixels to red
                        bmp.SetPixel(x, y, Color.Red);
                    }
                    else if (pixelColor.R == 255)
                    {
                        // Change red pixels to transparent
                        bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                    }
                }
            }
            Gamemask = bmp;
            DrawMask();

        }
        private void DrawMask() 
        {
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
                comb.DrawImage(Gamemask, new Rectangle(0, 0, Gamemask.Width, Gamemask.Height), 0, 0, Gamemask.Width, Gamemask.Height, GraphicsUnit.Pixel, imageAttributes);
                //comb.DrawImage(Gamemask,0,0);
            }
            picbxLevelEditor.Image = (Image)bmp;
        }

        private void picbxLevelEditor_Paint(object sender, PaintEventArgs e)
        {
            if (GameMaskMode) 
            {
                Rectangle borderRectangle = this.picbxLevelEditor.ClientRectangle;
                ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, ButtonBorderStyle.Solid);
                borderRectangle.Inflate(-1, -1);
                ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, ButtonBorderStyle.Solid);
                borderRectangle.Inflate(-2, -2);
                ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, ButtonBorderStyle.Solid);
                borderRectangle.Inflate(-3, -3);
                ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, ButtonBorderStyle.Solid);
                borderRectangle.Inflate(-4, -4);
                ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, ButtonBorderStyle.Solid);
                borderRectangle.Inflate(-5, -5);
                ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, ButtonBorderStyle.Solid);
                borderRectangle.Inflate(-6, -6);
                ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.Red, ButtonBorderStyle.Solid);

            }
        }

        private void bttnToggleGamemask_Click(object sender, EventArgs e)
        {
            ToggleGameMask();
        }
        #endregion
    }
}
/*
 public partial class LevelEditorForm : Form
{
    // The current color that will be used to draw on the picture box
    private Color _penColor = Color.Black;

    // The image that will be used as the background for the level
    private Image _levelImage;

    // A list of points that represents the path that enemies will follow
    private List<Point> _enemyPath = new List<Point>();

    public LevelEditorForm()
    {
        InitializeComponent();
    }

    private void LevelEditorForm_Load(object sender, EventArgs e)
    {
        // Set up the picture box
        levelPictureBox.BackColor = Color.White;
        levelPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        // Set up the color buttons
        blackButton.BackColor = Color.Black;
        redButton.BackColor = Color.Red;
        greenButton.BackColor = Color.Green;
        blueButton.BackColor = Color.Blue;
    }

    private void blackButton_Click(object sender, EventArgs e)
    {
        // Set the pen color to black
        _penColor = Color.Black;
    }

    private void redButton_Click(object sender, EventArgs e)
    {
        // Set the pen color to red
        _penColor = Color.Red;
    }

    private void greenButton_Click(object sender, EventArgs e)
    {
        // Set the pen color to green
        _penColor = Color.Green;
    }

    private void blueButton_Click(object sender, EventArgs e)
    {
        // Set the pen color to blue
        _penColor = Color.Blue;
    }

    private void levelPictureBox_Mouse

 */
