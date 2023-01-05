
namespace FriedVideoGame
{
    partial class LevelEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelEditor));
            this.picbxLevelEditor = new System.Windows.Forms.PictureBox();
            this.bttnBlack = new System.Windows.Forms.Button();
            this.bttnGray = new System.Windows.Forms.Button();
            this.bttnBlue = new System.Windows.Forms.Button();
            this.bttnGreen = new System.Windows.Forms.Button();
            this.bttSmall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bttnPoint = new System.Windows.Forms.Button();
            this.bttnWhite = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnFill = new System.Windows.Forms.Button();
            this.bttnBrown = new System.Windows.Forms.Button();
            this.bttnLightGreen = new System.Windows.Forms.Button();
            this.bttnDarkGreen = new System.Windows.Forms.Button();
            this.bttnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnLoad = new System.Windows.Forms.Button();
            this.bttnClearPoints = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillWithColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstbxVersions = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.bttnPlay = new System.Windows.Forms.Button();
            this.bttnScreen = new System.Windows.Forms.Button();
            this.bttnYellow = new System.Windows.Forms.Button();
            this.bttnLightBlue = new System.Windows.Forms.Button();
            this.bttnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.gamemaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnToggleGamemask = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnInvertGamemask = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnClearGameMask = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picbxLevelEditor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbxLevelEditor
            // 
            this.picbxLevelEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picbxLevelEditor.Location = new System.Drawing.Point(8, 89);
            this.picbxLevelEditor.Name = "picbxLevelEditor";
            this.picbxLevelEditor.Size = new System.Drawing.Size(499, 254);
            this.picbxLevelEditor.TabIndex = 0;
            this.picbxLevelEditor.TabStop = false;
            this.picbxLevelEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.picbxLevelEditor_Paint);
            this.picbxLevelEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picbxLevelEditor_MouseClick);
            this.picbxLevelEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picbxLevelEditor_MouseDown);
            this.picbxLevelEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbxLevelEditor_MouseMove);
            this.picbxLevelEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picbxLevelEditor_MouseUp);
            // 
            // bttnBlack
            // 
            this.bttnBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnBlack.Location = new System.Drawing.Point(133, 415);
            this.bttnBlack.Name = "bttnBlack";
            this.bttnBlack.Size = new System.Drawing.Size(53, 43);
            this.bttnBlack.TabIndex = 1;
            this.bttnBlack.Text = "button1";
            this.bttnBlack.UseVisualStyleBackColor = true;
            this.bttnBlack.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnGray
            // 
            this.bttnGray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnGray.Location = new System.Drawing.Point(74, 415);
            this.bttnGray.Name = "bttnGray";
            this.bttnGray.Size = new System.Drawing.Size(53, 43);
            this.bttnGray.TabIndex = 2;
            this.bttnGray.Text = "button2";
            this.bttnGray.UseVisualStyleBackColor = true;
            this.bttnGray.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnBlue
            // 
            this.bttnBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnBlue.Location = new System.Drawing.Point(251, 366);
            this.bttnBlue.Name = "bttnBlue";
            this.bttnBlue.Size = new System.Drawing.Size(53, 43);
            this.bttnBlue.TabIndex = 4;
            this.bttnBlue.Text = "button3";
            this.bttnBlue.UseVisualStyleBackColor = true;
            this.bttnBlue.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnGreen
            // 
            this.bttnGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnGreen.Location = new System.Drawing.Point(74, 366);
            this.bttnGreen.Name = "bttnGreen";
            this.bttnGreen.Size = new System.Drawing.Size(53, 43);
            this.bttnGreen.TabIndex = 3;
            this.bttnGreen.Text = "button4";
            this.bttnGreen.UseVisualStyleBackColor = true;
            this.bttnGreen.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttSmall
            // 
            this.bttSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSmall.Location = new System.Drawing.Point(513, 72);
            this.bttSmall.Name = "bttSmall";
            this.bttSmall.Size = new System.Drawing.Size(53, 43);
            this.bttSmall.TabIndex = 5;
            this.bttSmall.Text = "•";
            this.bttSmall.UseVisualStyleBackColor = true;
            this.bttSmall.Click += new System.EventHandler(this.bttnSize_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(513, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "•";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bttnSize_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(513, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "•";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bttnSize_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(513, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "•";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bttnSize_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(513, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 43);
            this.button4.TabIndex = 9;
            this.button4.Text = "•";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bttnSize_Click);
            // 
            // bttnPoint
            // 
            this.bttnPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnPoint.Location = new System.Drawing.Point(513, 317);
            this.bttnPoint.Name = "bttnPoint";
            this.bttnPoint.Size = new System.Drawing.Size(53, 43);
            this.bttnPoint.TabIndex = 10;
            this.bttnPoint.Text = "Path Point";
            this.bttnPoint.UseVisualStyleBackColor = true;
            this.bttnPoint.Click += new System.EventHandler(this.bttnPoint_Click);
            // 
            // bttnWhite
            // 
            this.bttnWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnWhite.Location = new System.Drawing.Point(15, 415);
            this.bttnWhite.Name = "bttnWhite";
            this.bttnWhite.Size = new System.Drawing.Size(53, 43);
            this.bttnWhite.TabIndex = 11;
            this.bttnWhite.Text = "button3";
            this.bttnWhite.UseVisualStyleBackColor = true;
            this.bttnWhite.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnClear.Location = new System.Drawing.Point(454, 366);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(53, 43);
            this.bttnClear.TabIndex = 12;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // bttnFill
            // 
            this.bttnFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnFill.Location = new System.Drawing.Point(395, 366);
            this.bttnFill.Name = "bttnFill";
            this.bttnFill.Size = new System.Drawing.Size(53, 43);
            this.bttnFill.TabIndex = 13;
            this.bttnFill.Text = "Fill";
            this.bttnFill.UseVisualStyleBackColor = true;
            this.bttnFill.Click += new System.EventHandler(this.bttnFill_Click);
            // 
            // bttnBrown
            // 
            this.bttnBrown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnBrown.Location = new System.Drawing.Point(192, 415);
            this.bttnBrown.Name = "bttnBrown";
            this.bttnBrown.Size = new System.Drawing.Size(53, 43);
            this.bttnBrown.TabIndex = 14;
            this.bttnBrown.Text = "button3";
            this.bttnBrown.UseVisualStyleBackColor = true;
            this.bttnBrown.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnLightGreen
            // 
            this.bttnLightGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnLightGreen.Location = new System.Drawing.Point(15, 366);
            this.bttnLightGreen.Name = "bttnLightGreen";
            this.bttnLightGreen.Size = new System.Drawing.Size(53, 43);
            this.bttnLightGreen.TabIndex = 15;
            this.bttnLightGreen.Text = "button4";
            this.bttnLightGreen.UseVisualStyleBackColor = true;
            this.bttnLightGreen.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnDarkGreen
            // 
            this.bttnDarkGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnDarkGreen.Location = new System.Drawing.Point(133, 366);
            this.bttnDarkGreen.Name = "bttnDarkGreen";
            this.bttnDarkGreen.Size = new System.Drawing.Size(53, 43);
            this.bttnDarkGreen.TabIndex = 16;
            this.bttnDarkGreen.Text = "button4";
            this.bttnDarkGreen.UseVisualStyleBackColor = true;
            this.bttnDarkGreen.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnSave
            // 
            this.bttnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnSave.Location = new System.Drawing.Point(395, 416);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(85, 43);
            this.bttnSave.TabIndex = 17;
            this.bttnSave.Text = "Save Game";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // bttnLoad
            // 
            this.bttnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnLoad.Location = new System.Drawing.Point(481, 416);
            this.bttnLoad.Name = "bttnLoad";
            this.bttnLoad.Size = new System.Drawing.Size(85, 43);
            this.bttnLoad.TabIndex = 19;
            this.bttnLoad.Text = "Load Game";
            this.bttnLoad.UseVisualStyleBackColor = true;
            this.bttnLoad.Click += new System.EventHandler(this.bttnLoad_Click);
            // 
            // bttnClearPoints
            // 
            this.bttnClearPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnClearPoints.Location = new System.Drawing.Point(513, 366);
            this.bttnClearPoints.Name = "bttnClearPoints";
            this.bttnClearPoints.Size = new System.Drawing.Size(53, 43);
            this.bttnClearPoints.TabIndex = 25;
            this.bttnClearPoints.Text = "Clear Points";
            this.bttnClearPoints.UseVisualStyleBackColor = true;
            this.bttnClearPoints.Click += new System.EventHandler(this.bttnClearPoints_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 9);
            this.label5.TabIndex = 26;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(569, 333);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(219, 126);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(569, 232);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(219, 95);
            this.richTextBox2.TabIndex = 29;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tutorials:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.gamemaskToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.bttnNew});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.bttnLoad_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnUndo,
            this.bttnRedo,
            this.clearToolStripMenuItem,
            this.fillWithColourToolStripMenuItem,
            this.clearPointsToolStripMenuItem,
            this.newPointToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // bttnUndo
            // 
            this.bttnUndo.Name = "bttnUndo";
            this.bttnUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.bttnUndo.Size = new System.Drawing.Size(196, 22);
            this.bttnUndo.Text = "Undo";
            this.bttnUndo.Click += new System.EventHandler(this.bttnUndo_Click);
            // 
            // bttnRedo
            // 
            this.bttnRedo.Name = "bttnRedo";
            this.bttnRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.bttnRedo.Size = new System.Drawing.Size(196, 22);
            this.bttnRedo.Text = "Redo";
            this.bttnRedo.Click += new System.EventHandler(this.bttnRedo_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // fillWithColourToolStripMenuItem
            // 
            this.fillWithColourToolStripMenuItem.Name = "fillWithColourToolStripMenuItem";
            this.fillWithColourToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fillWithColourToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.fillWithColourToolStripMenuItem.Text = "Fill With Colour";
            this.fillWithColourToolStripMenuItem.Click += new System.EventHandler(this.bttnFill_Click);
            // 
            // clearPointsToolStripMenuItem
            // 
            this.clearPointsToolStripMenuItem.Name = "clearPointsToolStripMenuItem";
            this.clearPointsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearPointsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.clearPointsToolStripMenuItem.Text = "Clear Points";
            this.clearPointsToolStripMenuItem.Click += new System.EventHandler(this.bttnClearPoints_Click);
            // 
            // newPointToolStripMenuItem
            // 
            this.newPointToolStripMenuItem.Name = "newPointToolStripMenuItem";
            this.newPointToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.newPointToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.newPointToolStripMenuItem.Text = "New Point";
            this.newPointToolStripMenuItem.Click += new System.EventHandler(this.bttnPoint_Click);
            // 
            // lstbxVersions
            // 
            this.lstbxVersions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbxVersions.Enabled = false;
            this.lstbxVersions.FormattingEnabled = true;
            this.lstbxVersions.Location = new System.Drawing.Point(668, 107);
            this.lstbxVersions.Name = "lstbxVersions";
            this.lstbxVersions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstbxVersions.Size = new System.Drawing.Size(120, 95);
            this.lstbxVersions.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Versions:";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(738, 87);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(15, 16);
            this.lblVersion.TabIndex = 35;
            this.lblVersion.Text = "0";
            // 
            // bttnPlay
            // 
            this.bttnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnPlay.Location = new System.Drawing.Point(586, 107);
            this.bttnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnPlay.Name = "bttnPlay";
            this.bttnPlay.Size = new System.Drawing.Size(56, 50);
            this.bttnPlay.TabIndex = 36;
            this.bttnPlay.Text = "Play";
            this.bttnPlay.UseVisualStyleBackColor = true;
            this.bttnPlay.Click += new System.EventHandler(this.bttnPlay_Click);
            // 
            // bttnScreen
            // 
            this.bttnScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnScreen.Location = new System.Drawing.Point(668, 25);
            this.bttnScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnScreen.Name = "bttnScreen";
            this.bttnScreen.Size = new System.Drawing.Size(119, 47);
            this.bttnScreen.TabIndex = 37;
            this.bttnScreen.Text = "Fullscreen";
            this.bttnScreen.UseVisualStyleBackColor = true;
            this.bttnScreen.Click += new System.EventHandler(this.bttnScreen_Click);
            // 
            // bttnYellow
            // 
            this.bttnYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnYellow.Location = new System.Drawing.Point(251, 415);
            this.bttnYellow.Name = "bttnYellow";
            this.bttnYellow.Size = new System.Drawing.Size(53, 43);
            this.bttnYellow.TabIndex = 38;
            this.bttnYellow.Text = "button3";
            this.bttnYellow.UseVisualStyleBackColor = true;
            this.bttnYellow.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnLightBlue
            // 
            this.bttnLightBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnLightBlue.Location = new System.Drawing.Point(192, 366);
            this.bttnLightBlue.Name = "bttnLightBlue";
            this.bttnLightBlue.Size = new System.Drawing.Size(53, 43);
            this.bttnLightBlue.TabIndex = 39;
            this.bttnLightBlue.Text = "button3";
            this.bttnLightBlue.UseVisualStyleBackColor = true;
            this.bttnLightBlue.Click += new System.EventHandler(this.bttnColour_Click);
            // 
            // bttnNew
            // 
            this.bttnNew.Name = "bttnNew";
            this.bttnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.bttnNew.Size = new System.Drawing.Size(180, 22);
            this.bttnNew.Text = "New";
            this.bttnNew.Click += new System.EventHandler(this.bttnNew_Click);
            // 
            // gamemaskToolStripMenuItem
            // 
            this.gamemaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttnToggleGamemask,
            this.bttnInvertGamemask,
            this.bttnClearGameMask});
            this.gamemaskToolStripMenuItem.Name = "gamemaskToolStripMenuItem";
            this.gamemaskToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.gamemaskToolStripMenuItem.Text = "Gamemask";
            // 
            // bttnToggleGamemask
            // 
            this.bttnToggleGamemask.Name = "bttnToggleGamemask";
            this.bttnToggleGamemask.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.bttnToggleGamemask.Size = new System.Drawing.Size(259, 22);
            this.bttnToggleGamemask.Text = "Toggle gamemask";
            this.bttnToggleGamemask.Click += new System.EventHandler(this.bttnToggleGamemask_Click);
            // 
            // bttnInvertGamemask
            // 
            this.bttnInvertGamemask.Name = "bttnInvertGamemask";
            this.bttnInvertGamemask.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.bttnInvertGamemask.Size = new System.Drawing.Size(259, 22);
            this.bttnInvertGamemask.Text = "Invert gamemask";
            this.bttnInvertGamemask.Click += new System.EventHandler(this.bttnInvertGamemask_Click);
            // 
            // bttnClearGameMask
            // 
            this.bttnClearGameMask.Name = "bttnClearGameMask";
            this.bttnClearGameMask.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.bttnClearGameMask.Size = new System.Drawing.Size(259, 22);
            this.bttnClearGameMask.Text = "Clear gamemask";
            this.bttnClearGameMask.Click += new System.EventHandler(this.bttnClearGameMask_Click);
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(802, 474);
            this.Controls.Add(this.bttnLightBlue);
            this.Controls.Add(this.bttnYellow);
            this.Controls.Add(this.bttnScreen);
            this.Controls.Add(this.bttnPlay);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstbxVersions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnClearPoints);
            this.Controls.Add(this.bttnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.bttnDarkGreen);
            this.Controls.Add(this.bttnLightGreen);
            this.Controls.Add(this.bttnBrown);
            this.Controls.Add(this.bttnFill);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnWhite);
            this.Controls.Add(this.bttnPoint);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttSmall);
            this.Controls.Add(this.bttnBlue);
            this.Controls.Add(this.bttnGreen);
            this.Controls.Add(this.bttnGray);
            this.Controls.Add(this.bttnBlack);
            this.Controls.Add(this.picbxLevelEditor);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1936, 1056);
            this.MinimumSize = new System.Drawing.Size(818, 513);
            this.Name = "LevelEditor";
            this.Text = "Level Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picbxLevelEditor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxLevelEditor;
        private System.Windows.Forms.Button bttnBlack;
        private System.Windows.Forms.Button bttnGray;
        private System.Windows.Forms.Button bttnBlue;
        private System.Windows.Forms.Button bttnGreen;
        private System.Windows.Forms.Button bttSmall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bttnPoint;
        private System.Windows.Forms.Button bttnWhite;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button bttnFill;
        private System.Windows.Forms.Button bttnBrown;
        private System.Windows.Forms.Button bttnLightGreen;
        private System.Windows.Forms.Button bttnDarkGreen;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnLoad;
        private System.Windows.Forms.Button bttnClearPoints;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bttnUndo;
        private System.Windows.Forms.ToolStripMenuItem bttnRedo;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillWithColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPointToolStripMenuItem;
        private System.Windows.Forms.ListBox lstbxVersions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button bttnPlay;
        private System.Windows.Forms.Button bttnScreen;
        private System.Windows.Forms.Button bttnYellow;
        private System.Windows.Forms.Button bttnLightBlue;
        private System.Windows.Forms.ToolStripMenuItem bttnNew;
        private System.Windows.Forms.ToolStripMenuItem gamemaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bttnToggleGamemask;
        private System.Windows.Forms.ToolStripMenuItem bttnInvertGamemask;
        private System.Windows.Forms.ToolStripMenuItem bttnClearGameMask;
    }
}