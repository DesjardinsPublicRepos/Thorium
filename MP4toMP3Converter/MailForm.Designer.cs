namespace MP4toMP3Converter
{
    partial class MailForm
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
            this.MailBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SubjectBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sendButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BodyTextBox = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // MailBox
            // 
            this.MailBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MailBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MailBox.ForeColor = System.Drawing.Color.White;
            this.MailBox.HintForeColor = System.Drawing.Color.White;
            this.MailBox.HintText = "";
            this.MailBox.isPassword = false;
            this.MailBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.MailBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.MailBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.MailBox.LineThickness = 3;
            this.MailBox.Location = new System.Drawing.Point(470, 76);
            this.MailBox.Margin = new System.Windows.Forms.Padding(4);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(256, 33);
            this.MailBox.TabIndex = 2;
            this.MailBox.Text = "E - Mail";
            this.MailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MailBox.Enter += new System.EventHandler(this.TextboxesEnter);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.HintForeColor = System.Drawing.Color.White;
            this.PasswordBox.HintText = "";
            this.PasswordBox.isPassword = false;
            this.PasswordBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.PasswordBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.PasswordBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.PasswordBox.LineThickness = 3;
            this.PasswordBox.Location = new System.Drawing.Point(470, 164);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(256, 33);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordBox.Enter += new System.EventHandler(this.TextboxesEnter);
            // 
            // SubjectBox
            // 
            this.SubjectBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubjectBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SubjectBox.ForeColor = System.Drawing.Color.White;
            this.SubjectBox.HintForeColor = System.Drawing.Color.White;
            this.SubjectBox.HintText = "";
            this.SubjectBox.isPassword = false;
            this.SubjectBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.SubjectBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.SubjectBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.SubjectBox.LineThickness = 3;
            this.SubjectBox.Location = new System.Drawing.Point(28, 76);
            this.SubjectBox.Margin = new System.Windows.Forms.Padding(4);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(406, 33);
            this.SubjectBox.TabIndex = 4;
            this.SubjectBox.Text = "Subject";
            this.SubjectBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SubjectBox.Enter += new System.EventHandler(this.TextboxesEnter);
            // 
            // sendButton
            // 
            this.sendButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.BorderRadius = 0;
            this.sendButton.ButtonText = "send Mail";
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.DisabledColor = System.Drawing.Color.Gray;
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sendButton.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendButton.Iconimage = null;
            this.sendButton.Iconimage_right = null;
            this.sendButton.Iconimage_right_Selected = null;
            this.sendButton.Iconimage_Selected = null;
            this.sendButton.IconMarginLeft = 0;
            this.sendButton.IconMarginRight = 0;
            this.sendButton.IconRightVisible = true;
            this.sendButton.IconRightZoom = 0D;
            this.sendButton.IconVisible = true;
            this.sendButton.IconZoom = 90D;
            this.sendButton.IsTab = false;
            this.sendButton.Location = new System.Drawing.Point(505, 502);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendButton.Name = "sendButton";
            this.sendButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendButton.OnHoverTextColor = System.Drawing.Color.White;
            this.sendButton.selected = false;
            this.sendButton.Size = new System.Drawing.Size(184, 45);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "send Mail";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendButton.Textcolor = System.Drawing.Color.White;
            this.sendButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sendButton.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(28, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 413);
            this.textBox1.TabIndex = 8;
            // 
            // BodyTextBox
            // 
            this.BodyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BodyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BodyTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BodyTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BodyTextBox.Location = new System.Drawing.Point(33, 144);
            this.BodyTextBox.Multiline = true;
            this.BodyTextBox.Name = "BodyTextBox";
            this.BodyTextBox.Size = new System.Drawing.Size(396, 403);
            this.BodyTextBox.TabIndex = 9;
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
            this.bunifuElipse1.ElipseRadius = 4;
            this.bunifuElipse1.TargetControl = this.sendButton;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.textBox1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Send me an E - Mail";
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = this.label1;
            this.bunifuDragControl4.Vertical = true;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(760, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BodyTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.MailBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox MailBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SubjectBox;
        private Bunifu.Framework.UI.BunifuFlatButton sendButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox BodyTextBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
    }
}