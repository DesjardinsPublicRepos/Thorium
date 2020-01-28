namespace MP4toMP3Converter
{
    partial class LoadingPopup
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InfoLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.InfoLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AbortButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel1.ForeColor = System.Drawing.Color.Gray;
            this.InfoLabel1.Location = new System.Drawing.Point(46, 35);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(212, 28);
            this.InfoLabel1.TabIndex = 0;
            this.InfoLabel1.Text = "Loading... (0/0)";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel2.ForeColor = System.Drawing.Color.Gray;
            this.InfoLabel2.Location = new System.Drawing.Point(47, 81);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(98, 20);
            this.InfoLabel2.TabIndex = 1;
            this.InfoLabel2.Text = "Please wait";
            // 
            // ButtonElipse
            // 
            this.ButtonElipse.ElipseRadius = 5;
            this.ButtonElipse.TargetControl = this.AbortButton;
            // 
            // AbortButton
            // 
            this.AbortButton.Activecolor = System.Drawing.Color.Silver;
            this.AbortButton.BackColor = System.Drawing.Color.Gray;
            this.AbortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AbortButton.BorderRadius = 0;
            this.AbortButton.ButtonText = "abort converting process";
            this.AbortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbortButton.DisabledColor = System.Drawing.Color.Gray;
            this.AbortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbortButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AbortButton.Iconimage = null;
            this.AbortButton.Iconimage_right = null;
            this.AbortButton.Iconimage_right_Selected = null;
            this.AbortButton.Iconimage_Selected = null;
            this.AbortButton.IconMarginLeft = 0;
            this.AbortButton.IconMarginRight = 0;
            this.AbortButton.IconRightVisible = true;
            this.AbortButton.IconRightZoom = 0D;
            this.AbortButton.IconVisible = true;
            this.AbortButton.IconZoom = 90D;
            this.AbortButton.IsTab = false;
            this.AbortButton.Location = new System.Drawing.Point(76, 243);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(4);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Normalcolor = System.Drawing.Color.Gray;
            this.AbortButton.OnHovercolor = System.Drawing.Color.Silver;
            this.AbortButton.OnHoverTextColor = System.Drawing.Color.White;
            this.AbortButton.selected = false;
            this.AbortButton.Size = new System.Drawing.Size(321, 59);
            this.AbortButton.TabIndex = 3;
            this.AbortButton.Text = "abort converting process";
            this.AbortButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AbortButton.Textcolor = System.Drawing.Color.White;
            this.AbortButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MP4toMP3Converter.Properties.Resources.newLoad;
            this.pictureBox1.Location = new System.Drawing.Point(184, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(485, 338);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.InfoLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingPopup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel InfoLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton AbortButton;
        private Bunifu.Framework.UI.BunifuElipse ButtonElipse;
        public Bunifu.Framework.UI.BunifuCustomLabel InfoLabel1;
    }
}