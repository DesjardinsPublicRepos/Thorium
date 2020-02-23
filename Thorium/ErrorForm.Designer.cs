namespace MP4toMP3Converter
{
    partial class ErrorForm
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.heading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AbortButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.heading.ForeColor = System.Drawing.Color.Gray;
            this.heading.Location = new System.Drawing.Point(47, 31);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(65, 33);
            this.heading.TabIndex = 11;
            this.heading.Text = "title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "___________________________________";
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.text.ForeColor = System.Drawing.Color.Gray;
            this.text.Location = new System.Drawing.Point(48, 86);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(377, 156);
            this.text.TabIndex = 9;
            this.text.Text = "text";
            // 
            // AbortButton
            // 
            this.AbortButton.Activecolor = System.Drawing.Color.Silver;
            this.AbortButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AbortButton.BackColor = System.Drawing.Color.Gray;
            this.AbortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AbortButton.BorderRadius = 0;
            this.AbortButton.ButtonText = "OK";
            this.AbortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbortButton.DisabledColor = System.Drawing.Color.Gray;
            this.AbortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.AbortButton.Location = new System.Drawing.Point(202, 200);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(4);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Normalcolor = System.Drawing.Color.Gray;
            this.AbortButton.OnHovercolor = System.Drawing.Color.Silver;
            this.AbortButton.OnHoverTextColor = System.Drawing.Color.White;
            this.AbortButton.selected = false;
            this.AbortButton.Size = new System.Drawing.Size(92, 34);
            this.AbortButton.TabIndex = 12;
            this.AbortButton.Text = "OK";
            this.AbortButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AbortButton.Textcolor = System.Drawing.Color.White;
            this.AbortButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.AbortButton;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 262);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuCustomLabel heading;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel text;
        private Bunifu.Framework.UI.BunifuFlatButton AbortButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}