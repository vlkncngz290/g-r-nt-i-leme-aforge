namespace Görüntü_işleme
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dOSYAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griTonlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.TrackBar();
            this.blue = new System.Windows.Forms.TrackBar();
            this.green = new System.Windows.Forms.TrackBar();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redTrackMax = new System.Windows.Forms.TrackBar();
            this.greenTrackMax = new System.Windows.Forms.TrackBar();
            this.blueTrackMax = new System.Windows.Forms.TrackBar();
            this.numericUpDownRedMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreenMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBlueMax = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreenMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlueMax)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOSYAToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dOSYAToolStripMenuItem
            // 
            this.dOSYAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇToolStripMenuItem,
            this.kameraAçToolStripMenuItem});
            this.dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            this.dOSYAToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dOSYAToolStripMenuItem.Text = "Dosya";
            // 
            // aÇToolStripMenuItem
            // 
            this.aÇToolStripMenuItem.Name = "aÇToolStripMenuItem";
            this.aÇToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aÇToolStripMenuItem.Text = "Aç";
            this.aÇToolStripMenuItem.Click += new System.EventHandler(this.aÇToolStripMenuItem_Click);
            // 
            // kameraAçToolStripMenuItem
            // 
            this.kameraAçToolStripMenuItem.Name = "kameraAçToolStripMenuItem";
            this.kameraAçToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kameraAçToolStripMenuItem.Text = "Kamera Aç";
            this.kameraAçToolStripMenuItem.Click += new System.EventHandler(this.kameraAçToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griTonlamaToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // griTonlamaToolStripMenuItem
            // 
            this.griTonlamaToolStripMenuItem.Name = "griTonlamaToolStripMenuItem";
            this.griTonlamaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.griTonlamaToolStripMenuItem.Text = "Gri Tonlama";
            this.griTonlamaToolStripMenuItem.Click += new System.EventHandler(this.griTonlamaToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14577F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85423F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 365);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(461, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 359);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fotoğraf Çek";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Takip";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(15, 401);
            this.red.Maximum = 255;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(337, 45);
            this.red.TabIndex = 5;
            this.red.Scroll += new System.EventHandler(this.red_Scroll);
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(15, 503);
            this.blue.Maximum = 255;
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(337, 45);
            this.blue.TabIndex = 6;
            this.blue.Scroll += new System.EventHandler(this.blue_Scroll);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(15, 452);
            this.green.Maximum = 255;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(337, 45);
            this.green.TabIndex = 7;
            this.green.Scroll += new System.EventHandler(this.green_Scroll);
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(358, 401);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRed.TabIndex = 8;
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(358, 503);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBlue.TabIndex = 9;
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(358, 452);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGreen.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "green";
            // 
            // redTrackMax
            // 
            this.redTrackMax.Location = new System.Drawing.Point(484, 401);
            this.redTrackMax.Maximum = 255;
            this.redTrackMax.Name = "redTrackMax";
            this.redTrackMax.Size = new System.Drawing.Size(337, 45);
            this.redTrackMax.TabIndex = 14;
            this.redTrackMax.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // greenTrackMax
            // 
            this.greenTrackMax.Location = new System.Drawing.Point(484, 452);
            this.greenTrackMax.Maximum = 255;
            this.greenTrackMax.Name = "greenTrackMax";
            this.greenTrackMax.Size = new System.Drawing.Size(337, 45);
            this.greenTrackMax.TabIndex = 15;
            this.greenTrackMax.Scroll += new System.EventHandler(this.greenTrackMax_Scroll);
            // 
            // blueTrackMax
            // 
            this.blueTrackMax.Location = new System.Drawing.Point(484, 494);
            this.blueTrackMax.Maximum = 255;
            this.blueTrackMax.Name = "blueTrackMax";
            this.blueTrackMax.Size = new System.Drawing.Size(337, 45);
            this.blueTrackMax.TabIndex = 16;
            this.blueTrackMax.Scroll += new System.EventHandler(this.blueTrackMax_Scroll);
            // 
            // numericUpDownRedMax
            // 
            this.numericUpDownRedMax.Location = new System.Drawing.Point(827, 401);
            this.numericUpDownRedMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRedMax.Name = "numericUpDownRedMax";
            this.numericUpDownRedMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRedMax.TabIndex = 17;
            // 
            // numericUpDownGreenMax
            // 
            this.numericUpDownGreenMax.Location = new System.Drawing.Point(827, 452);
            this.numericUpDownGreenMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreenMax.Name = "numericUpDownGreenMax";
            this.numericUpDownGreenMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGreenMax.TabIndex = 18;
            // 
            // numericUpDownBlueMax
            // 
            this.numericUpDownBlueMax.Location = new System.Drawing.Point(827, 494);
            this.numericUpDownBlueMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlueMax.Name = "numericUpDownBlueMax";
            this.numericUpDownBlueMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBlueMax.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 560);
            this.Controls.Add(this.numericUpDownBlueMax);
            this.Controls.Add(this.numericUpDownGreenMax);
            this.Controls.Add(this.numericUpDownRedMax);
            this.Controls.Add(this.blueTrackMax);
            this.Controls.Add(this.greenTrackMax);
            this.Controls.Add(this.redTrackMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.green);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.red);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreenMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlueMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dOSYAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aÇToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griTonlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kameraAçToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar red;
        private System.Windows.Forms.TrackBar blue;
        private System.Windows.Forms.TrackBar green;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar redTrackMax;
        private System.Windows.Forms.TrackBar greenTrackMax;
        private System.Windows.Forms.TrackBar blueTrackMax;
        private System.Windows.Forms.NumericUpDown numericUpDownRedMax;
        private System.Windows.Forms.NumericUpDown numericUpDownGreenMax;
        private System.Windows.Forms.NumericUpDown numericUpDownBlueMax;
    }
}

