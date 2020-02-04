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
            this.FormDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InfoLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ButtonElipse0 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AbortButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label0DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InfoLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label1DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.AnimDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.line1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.line1DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormDragControl
            // 
            this.FormDragControl.Fixed = true;
            this.FormDragControl.Horizontal = true;
            this.FormDragControl.TargetControl = this;
            this.FormDragControl.Vertical = true;
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel2.ForeColor = System.Drawing.Color.Gray;
            this.InfoLabel2.Location = new System.Drawing.Point(47, 89);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(103, 20);
            this.InfoLabel2.TabIndex = 1;
            this.InfoLabel2.Text = "Please wait.";
            // 
            // ButtonElipse0
            // 
            this.ButtonElipse0.ElipseRadius = 3;
            this.ButtonElipse0.TargetControl = this.AbortButton;
            // 
            // AbortButton
            // 
            this.AbortButton.Activecolor = System.Drawing.Color.Silver;
            this.AbortButton.BackColor = System.Drawing.Color.Gray;
            this.AbortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AbortButton.BorderRadius = 0;
            this.AbortButton.ButtonText = "abort process";
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
            this.AbortButton.Location = new System.Drawing.Point(142, 269);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(4);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Normalcolor = System.Drawing.Color.Gray;
            this.AbortButton.OnHovercolor = System.Drawing.Color.Silver;
            this.AbortButton.OnHoverTextColor = System.Drawing.Color.White;
            this.AbortButton.selected = false;
            this.AbortButton.Size = new System.Drawing.Size(184, 44);
            this.AbortButton.TabIndex = 3;
            this.AbortButton.Text = "abort process";
            this.AbortButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AbortButton.Textcolor = System.Drawing.Color.White;
            this.AbortButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MP4toMP3Converter.Properties.Resources.newLoad;
            this.pictureBox1.Location = new System.Drawing.Point(184, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Label0DragControl
            // 
            this.Label0DragControl.Fixed = true;
            this.Label0DragControl.Horizontal = true;
            this.Label0DragControl.TargetControl = this.InfoLabel1;
            this.Label0DragControl.Vertical = true;
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel1.ForeColor = System.Drawing.Color.Gray;
            this.InfoLabel1.Location = new System.Drawing.Point(46, 34);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(212, 28);
            this.InfoLabel1.TabIndex = 5;
            this.InfoLabel1.Text = "Loading... (1/1)";
            // 
            // Label1DragControl
            // 
            this.Label1DragControl.Fixed = true;
            this.Label1DragControl.Horizontal = true;
            this.Label1DragControl.TargetControl = this.InfoLabel2;
            this.Label1DragControl.Vertical = true;
            // 
            // AnimDragControl
            // 
            this.AnimDragControl.Fixed = true;
            this.AnimDragControl.Horizontal = true;
            this.AnimDragControl.TargetControl = this.pictureBox1;
            this.AnimDragControl.Vertical = true;
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.line1.Location = new System.Drawing.Point(25, 58);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(432, 25);
            this.line1.TabIndex = 4;
            this.line1.Text = "___________________________________";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // line1DragControl
            // 
            this.line1DragControl.Fixed = true;
            this.line1DragControl.Horizontal = true;
            this.line1DragControl.TargetControl = this.line1;
            this.line1DragControl.Vertical = true;
            // 
            // LoadingPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(485, 338);
            this.Controls.Add(this.InfoLabel1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfoLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingPopup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingPopup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl FormDragControl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel InfoLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton AbortButton;
        private Bunifu.Framework.UI.BunifuElipse ButtonElipse0;
        private Bunifu.Framework.UI.BunifuDragControl Label0DragControl;
        private Bunifu.Framework.UI.BunifuDragControl Label1DragControl;
        private Bunifu.Framework.UI.BunifuDragControl AnimDragControl;
        public Bunifu.Framework.UI.BunifuCustomLabel InfoLabel1;
        private System.Windows.Forms.Label line1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl line1DragControl;
    }
}