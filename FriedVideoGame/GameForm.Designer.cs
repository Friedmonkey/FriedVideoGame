
namespace FriedVideoGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnMonkey = new System.Windows.Forms.Button();
            this.GameArea2 = new System.Windows.Forms.Panel();
            this.GameArea = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnOpenGame = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnStartWave = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrThink = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GameArea2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.81512F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.18488F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GameArea2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttnMonkey, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(508, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97948F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.26714F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.75339F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(94, 362);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 61);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bttnMonkey
            // 
            this.bttnMonkey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnMonkey.BackgroundImage")));
            this.bttnMonkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnMonkey.Location = new System.Drawing.Point(3, 68);
            this.bttnMonkey.Name = "bttnMonkey";
            this.bttnMonkey.Size = new System.Drawing.Size(54, 46);
            this.bttnMonkey.TabIndex = 1;
            this.bttnMonkey.Text = "Monkey";
            this.bttnMonkey.UseVisualStyleBackColor = true;
            this.bttnMonkey.Click += new System.EventHandler(this.TowerButton_Click);
            // 
            // GameArea2
            // 
            this.GameArea2.BackColor = System.Drawing.Color.LimeGreen;
            this.GameArea2.Controls.Add(this.GameArea);
            this.GameArea2.Controls.Add(this.menuStrip1);
            this.GameArea2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameArea2.Location = new System.Drawing.Point(2, 2);
            this.GameArea2.Margin = new System.Windows.Forms.Padding(2);
            this.GameArea2.Name = "GameArea2";
            this.GameArea2.Size = new System.Drawing.Size(502, 362);
            this.GameArea2.TabIndex = 1;
            // 
            // GameArea
            // 
            this.GameArea.Image = ((System.Drawing.Image)(resources.GetObject("GameArea.Image")));
            this.GameArea.Location = new System.Drawing.Point(0, 93);
            this.GameArea.Name = "GameArea";
            this.GameArea.Size = new System.Drawing.Size(50, 50);
            this.GameArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameArea.TabIndex = 0;
            this.GameArea.TabStop = false;
            this.GameArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameArea_MouseClick);
            this.GameArea.MouseEnter += new System.EventHandler(this.GameArea_MouseEnter);
            this.GameArea.MouseLeave += new System.EventHandler(this.GameArea_MouseLeave);
            this.GameArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameArea_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnOpenGame});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bttnOpenGame
            // 
            this.bttnOpenGame.Name = "bttnOpenGame";
            this.bttnOpenGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.bttnOpenGame.Size = new System.Drawing.Size(180, 22);
            this.bttnOpenGame.Text = "Open Game";
            this.bttnOpenGame.Click += new System.EventHandler(this.bttnOpenGame_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnStartWave});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // bttnStartWave
            // 
            this.bttnStartWave.Name = "bttnStartWave";
            this.bttnStartWave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.bttnStartWave.Size = new System.Drawing.Size(170, 22);
            this.bttnStartWave.Text = "Startwave";
            this.bttnStartWave.Click += new System.EventHandler(this.bttnStartWave_Click);
            // 
            // tmrGameTime
            // 
            this.tmrGameTime.Tick += new System.EventHandler(this.tmrGameTime_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GameArea2.ResumeLayout(false);
            this.GameArea2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameArea)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel GameArea2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnMonkey;
        private System.Windows.Forms.PictureBox GameArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bttnOpenGame;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bttnStartWave;
        private System.Windows.Forms.Timer tmrGameTime;
        private System.Windows.Forms.Timer tmrThink;
    }
}

