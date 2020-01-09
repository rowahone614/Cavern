namespace Cavern
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.crusaderImage = new System.Windows.Forms.PictureBox();
            this.enternameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.playGameButton = new System.Windows.Forms.Button();
            this.exitGameButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crusaderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crusaderImage
            // 
            this.crusaderImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(41)))));
            this.crusaderImage.Image = ((System.Drawing.Image)(resources.GetObject("crusaderImage.Image")));
            this.crusaderImage.Location = new System.Drawing.Point(193, 266);
            this.crusaderImage.Name = "crusaderImage";
            this.crusaderImage.Size = new System.Drawing.Size(79, 41);
            this.crusaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crusaderImage.TabIndex = 29;
            this.crusaderImage.TabStop = false;
            // 
            // enternameLabel
            // 
            this.enternameLabel.AutoSize = true;
            this.enternameLabel.Font = new System.Drawing.Font("Pioneer BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enternameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.enternameLabel.Location = new System.Drawing.Point(277, 362);
            this.enternameLabel.Name = "enternameLabel";
            this.enternameLabel.Size = new System.Drawing.Size(249, 33);
            this.enternameLabel.TabIndex = 28;
            this.enternameLabel.Text = "Enter Your Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(269, 398);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(265, 20);
            this.nameInput.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(323, 504);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 159);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Pioneer BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.Location = new System.Drawing.Point(503, 436);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(163, 67);
            this.scoreButton.TabIndex = 25;
            this.scoreButton.Text = "High Scores";
            this.scoreButton.UseVisualStyleBackColor = false;
            this.scoreButton.Click += new System.EventHandler(this.ScoreButton_Click);
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.playGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.playGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGameButton.Font = new System.Drawing.Font("Pioneer BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.Location = new System.Drawing.Point(323, 436);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(163, 67);
            this.playGameButton.TabIndex = 24;
            this.playGameButton.Text = "Play Game";
            this.playGameButton.UseVisualStyleBackColor = false;
            this.playGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // exitGameButton
            // 
            this.exitGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
            this.exitGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGameButton.Font = new System.Drawing.Font("Pioneer BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitGameButton.Location = new System.Drawing.Point(139, 436);
            this.exitGameButton.Name = "exitGameButton";
            this.exitGameButton.Size = new System.Drawing.Size(163, 67);
            this.exitGameButton.TabIndex = 23;
            this.exitGameButton.Text = "Exit";
            this.exitGameButton.UseVisualStyleBackColor = false;
            this.exitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(611, 219);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 211);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(630, 542);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(72, 240);
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(39, 420);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(146, 362);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(269, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 147);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(717, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 219);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 159);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(41)))));
            this.label1.Font = new System.Drawing.Font("Pioneer BT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(113)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(49, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 87);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cavern Crusader";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.crusaderImage);
            this.Controls.Add(this.enternameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.exitGameButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(800, 800);
            ((System.ComponentModel.ISupportInitialize)(this.crusaderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox crusaderImage;
        private System.Windows.Forms.Label enternameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button exitGameButton;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
