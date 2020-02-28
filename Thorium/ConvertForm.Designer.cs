namespace Thorium
{
    partial class ConvertForm
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
            this.ItemListBoxDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.DragDropLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragDropLabel = new System.Windows.Forms.Label();
            this.InputLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.OutputLabel = new System.Windows.Forms.Label();
            this.FormDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.OutpuFormatLabel = new System.Windows.Forms.Label();
            this.formatDropdown = new System.Windows.Forms.ComboBox();
            this.ConvertButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.InputPathLabel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OutputPathLabel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.OpenOutput = new System.Windows.Forms.PictureBox();
            this.OpenInput = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OpenOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenInput)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemListBoxDragControl
            // 
            this.ItemListBoxDragControl.Fixed = true;
            this.ItemListBoxDragControl.Horizontal = true;
            this.ItemListBoxDragControl.TargetControl = this.ItemListBox;
            this.ItemListBoxDragControl.Vertical = true;
            // 
            // ItemListBox
            // 
            this.ItemListBox.AllowDrop = true;
            this.ItemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ItemListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBox.ForeColor = System.Drawing.Color.White;
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 20;
            this.ItemListBox.Location = new System.Drawing.Point(18, 20);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(434, 540);
            this.ItemListBox.TabIndex = 57;
            this.ItemListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxDragDrop);
            this.ItemListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxDragEnter);
            // 
            // DragDropLabelDragControl
            // 
            this.DragDropLabelDragControl.Fixed = true;
            this.DragDropLabelDragControl.Horizontal = true;
            this.DragDropLabelDragControl.TargetControl = this.DragDropLabel;
            this.DragDropLabelDragControl.Vertical = true;
            // 
            // DragDropLabel
            // 
            this.DragDropLabel.AllowDrop = true;
            this.DragDropLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragDropLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.DragDropLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DragDropLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.DragDropLabel.Location = new System.Drawing.Point(103, 272);
            this.DragDropLabel.Name = "DragDropLabel";
            this.DragDropLabel.Size = new System.Drawing.Size(236, 44);
            this.DragDropLabel.TabIndex = 58;
            this.DragDropLabel.Text = "Drag and Drop here";
            this.DragDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DragDropLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxDragDrop);
            this.DragDropLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxDragEnter);
            // 
            // InputLabelDragControl
            // 
            this.InputLabelDragControl.Fixed = true;
            this.InputLabelDragControl.Horizontal = true;
            this.InputLabelDragControl.TargetControl = this.InputLabel;
            this.InputLabelDragControl.Vertical = true;
            // 
            // InputLabel
            // 
            this.InputLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.InputLabel.Location = new System.Drawing.Point(469, 98);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(82, 16);
            this.InputLabel.TabIndex = 53;
            this.InputLabel.Text = "Add Input File";
            // 
            // OutputLabelDragControl
            // 
            this.OutputLabelDragControl.Fixed = true;
            this.OutputLabelDragControl.Horizontal = true;
            this.OutputLabelDragControl.TargetControl = this.OutputLabel;
            this.OutputLabelDragControl.Vertical = true;
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OutputLabel.Location = new System.Drawing.Point(468, 196);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(107, 16);
            this.OutputLabel.TabIndex = 52;
            this.OutputLabel.Text = "Filepath of Output";
            // 
            // FormDragControl
            // 
            this.FormDragControl.Fixed = true;
            this.FormDragControl.Horizontal = true;
            this.FormDragControl.TargetControl = this;
            this.FormDragControl.Vertical = true;
            // 
            // OutpuFormatLabel
            // 
            this.OutpuFormatLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OutpuFormatLabel.AutoSize = true;
            this.OutpuFormatLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OutpuFormatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.OutpuFormatLabel.Location = new System.Drawing.Point(509, 280);
            this.OutpuFormatLabel.Name = "OutpuFormatLabel";
            this.OutpuFormatLabel.Size = new System.Drawing.Size(106, 17);
            this.OutpuFormatLabel.TabIndex = 47;
            this.OutpuFormatLabel.Text = "Output format:";
            // 
            // formatDropdown
            // 
            this.formatDropdown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.formatDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.formatDropdown.Cursor = System.Windows.Forms.Cursors.Default;
            this.formatDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.formatDropdown.FormattingEnabled = true;
            this.formatDropdown.IntegralHeight = false;
            this.formatDropdown.ItemHeight = 16;
            this.formatDropdown.Items.AddRange(new object[] {
            "aiff",
            "au",
            "flac",
            "mp3",
            "ogg",
            "oga",
            "opus",
            "tta",
            "voc",
            "wav",
            "wv",
            "webm"});
            this.formatDropdown.Location = new System.Drawing.Point(633, 277);
            this.formatDropdown.Name = "formatDropdown";
            this.formatDropdown.Size = new System.Drawing.Size(69, 24);
            this.formatDropdown.TabIndex = 46;
            this.formatDropdown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutputBoxKeyDown);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConvertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConvertButton.BorderRadius = 0;
            this.ConvertButton.ButtonText = "convert";
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertButton.DisabledColor = System.Drawing.Color.Gray;
            this.ConvertButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ConvertButton.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConvertButton.Iconimage = null;
            this.ConvertButton.Iconimage_right = null;
            this.ConvertButton.Iconimage_right_Selected = null;
            this.ConvertButton.Iconimage_Selected = null;
            this.ConvertButton.IconMarginLeft = 0;
            this.ConvertButton.IconMarginRight = 0;
            this.ConvertButton.IconRightVisible = true;
            this.ConvertButton.IconRightZoom = 0D;
            this.ConvertButton.IconVisible = true;
            this.ConvertButton.IconZoom = 90D;
            this.ConvertButton.IsTab = false;
            this.ConvertButton.Location = new System.Drawing.Point(497, 454);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConvertButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConvertButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ConvertButton.selected = false;
            this.ConvertButton.Size = new System.Drawing.Size(219, 45);
            this.ConvertButton.TabIndex = 74;
            this.ConvertButton.Text = "convert";
            this.ConvertButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConvertButton.Textcolor = System.Drawing.Color.White;
            this.ConvertButton.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButtonClick);
            // 
            // InputPathLabel
            // 
            this.InputPathLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputPathLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.InputPathLabel.ForeColor = System.Drawing.Color.White;
            this.InputPathLabel.HintForeColor = System.Drawing.Color.White;
            this.InputPathLabel.HintText = "";
            this.InputPathLabel.isPassword = false;
            this.InputPathLabel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.InputPathLabel.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.InputPathLabel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.InputPathLabel.LineThickness = 3;
            this.InputPathLabel.Location = new System.Drawing.Point(470, 63);
            this.InputPathLabel.Margin = new System.Windows.Forms.Padding(4);
            this.InputPathLabel.Name = "InputPathLabel";
            this.InputPathLabel.Size = new System.Drawing.Size(277, 33);
            this.InputPathLabel.TabIndex = 75;
            this.InputPathLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InputPathLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBoxKeyDown);
            // 
            // OutputPathLabel
            // 
            this.OutputPathLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputPathLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.OutputPathLabel.ForeColor = System.Drawing.Color.White;
            this.OutputPathLabel.HintForeColor = System.Drawing.Color.White;
            this.OutputPathLabel.HintText = "";
            this.OutputPathLabel.isPassword = false;
            this.OutputPathLabel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OutputPathLabel.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.OutputPathLabel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OutputPathLabel.LineThickness = 3;
            this.OutputPathLabel.Location = new System.Drawing.Point(469, 160);
            this.OutputPathLabel.Margin = new System.Windows.Forms.Padding(4);
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Size = new System.Drawing.Size(277, 33);
            this.OutputPathLabel.TabIndex = 76;
            this.OutputPathLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OutputPathLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutputBoxKeyDown);
            // 
            // OpenOutput
            // 
            this.OpenOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.OpenOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenOutput.Image = global::Thorium.Properties.Resources.folder_2_open_512;
            this.OpenOutput.Location = new System.Drawing.Point(711, 160);
            this.OpenOutput.Name = "OpenOutput";
            this.OpenOutput.Size = new System.Drawing.Size(28, 20);
            this.OpenOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenOutput.TabIndex = 77;
            this.OpenOutput.TabStop = false;
            this.OpenOutput.Click += new System.EventHandler(this.OutputBoxClick);
            // 
            // OpenInput
            // 
            this.OpenInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(153)))));
            this.OpenInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenInput.Image = global::Thorium.Properties.Resources.folder_2_open_512;
            this.OpenInput.Location = new System.Drawing.Point(711, 63);
            this.OpenInput.Name = "OpenInput";
            this.OpenInput.Size = new System.Drawing.Size(28, 20);
            this.OpenInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenInput.TabIndex = 78;
            this.OpenInput.TabStop = false;
            this.OpenInput.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.DragDropLabel;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.ItemListBox;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.ConvertButton;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 3;
            this.bunifuElipse4.TargetControl = this.OpenInput;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 3;
            this.bunifuElipse5.TargetControl = this.OpenOutput;
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(760, 580);
            this.Controls.Add(this.OpenInput);
            this.Controls.Add(this.OpenOutput);
            this.Controls.Add(this.OutputPathLabel);
            this.Controls.Add(this.InputPathLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.formatDropdown);
            this.Controls.Add(this.DragDropLabel);
            this.Controls.Add(this.OutpuFormatLabel);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(760, 580);
            this.MinimumSize = new System.Drawing.Size(760, 580);
            this.Name = "ConvertForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.OpenOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl ItemListBoxDragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragDropLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl InputLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl OutputLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl FormDragControl;
        private System.Windows.Forms.Label OutpuFormatLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label DragDropLabel;
        private System.Windows.Forms.ComboBox formatDropdown;
        private Bunifu.Framework.UI.BunifuFlatButton ConvertButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox OutputPathLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputPathLabel;
        private System.Windows.Forms.PictureBox OpenInput;
        private System.Windows.Forms.PictureBox OpenOutput;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}