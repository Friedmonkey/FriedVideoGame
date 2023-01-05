using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FriedVideoGame
{
    class LevelRW
    {
        public Game GetGame()
        {
            Game game = new Game();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "FVG file *.fvg|*.fvg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(ofd.FileName);
                game = JsonConvert.DeserializeObject<Game>(text);
                return game;
            }
            return null;
        }
        public void SaveGame(Game game)
        {
            //Root rot = new Root() { game = game };
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "FVG file *.fvg|*.fvg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string text = JsonConvert.SerializeObject(game);
                //File.CreateText(sfd.FileName);
                //MessageBox.Show(String.Join("",Path.GetInvalidFileNameChars()));
                File.WriteAllText(sfd.FileName,text);
                MessageBox.Show("File saved!");
            }
        }
        public string Encode(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);

            byte[] bytes = ms.ToArray();

            //return "placeholder";
            return Convert.ToBase64String(bytes);
        }
        public Image Decode(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            MemoryStream ms = new MemoryStream();
            ms.Write(bytes, 0, bytes.Count());
            return Image.FromStream(ms);
        }
        //public class Root 
        //{
        //    public Game game { get; set; }
        //}
        public class Game
        {
            public string Background { get; set; }
            public List<Enemy> Enemies { get; set; }
            public List<Point> Path { get; set; }

            public string gameMask { get; set; }
            public bool gameMaskMode { get; set; }
        }
        public class Enemy
        {
            public string Sprite { get; set; }
            public int Speed { get; set; }
        }
        //public class Game
        //{
        //    public Image Background { get; set; }
        //    public List<Point> Path { get; set; }
        //    public List<Round> Rounds { get; set; }

        //    public int Time { get; set; }
        //    public int starterMoney { get; set; }

        //    public int Lives { get; set; }
        //}
        //public class Round 
        //{
        //    public List<Enemy> Enemies { get; set; }
        //}
        //public class Enemy
        //{
        //    public Image Sprite { get; set; }
        //    public int Speed { get; set; }
        //    public int Score { get; set; }

        //    public int spawnTime { get; set; }
        //    public int SpawnRound { get; set; }

        //    public bool Shrink { get; set; }
        //    public Enemy ShrinkEnemy { get; set; }
        //}
    }
}
public static class BitmapExtensions
{
    public static Image SetOpacity(this Image image, float opacity)
    {
        var colorMatrix = new ColorMatrix();
        colorMatrix.Matrix33 = opacity;
        var imageAttributes = new ImageAttributes();
        imageAttributes.SetColorMatrix(
            colorMatrix,
            ColorMatrixFlag.Default,
            ColorAdjustType.Bitmap);
        var output = new Bitmap(image.Width, image.Height);
        using (var gfx = Graphics.FromImage(output))
        {
            gfx.SmoothingMode = SmoothingMode.AntiAlias;
            gfx.DrawImage(
                image,
                new Rectangle(0, 0, image.Width, image.Height),
                0,
                0,
                image.Width,
                image.Height,
                GraphicsUnit.Pixel,
                imageAttributes);
        }
        return output;
    }
}
