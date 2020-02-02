namespace MP4toMP3Converter
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
            this.DragDropLabel = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ConvertLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OpenOutput = new System.Windows.Forms.PictureBox();
            this.ConvertButton = new System.Windows.Forms.PictureBox();
            this.OpenInput = new System.Windows.Forms.PictureBox();
            this.FormDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.OutputLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InputLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragDropLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ItemListBoxDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.formatDropdown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpenOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenInput)).BeginInit();
            this.SuspendLayout();
            // 
            // DragDropLabel
            // 
            this.DragDropLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragDropLabel.BackColor = System.Drawing.Color.MediumOrchid;
            this.DragDropLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DragDropLabel.Enabled = false;
            this.DragDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DragDropLabel.Location = new System.Drawing.Point(260, 266);
            this.DragDropLabel.Name = "DragDropLabel";
            this.DragDropLabel.Size = new System.Drawing.Size(236, 44);
            this.DragDropLabel.TabIndex = 32;
            this.DragDropLabel.Text = "Drag and Drop here";
            this.DragDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemListBox
            // 
            this.ItemListBox.AllowDrop = true;
            this.ItemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.ItemListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 20;
            this.ItemListBox.Location = new System.Drawing.Point(82, 135);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(615, 300);
            this.ItemListBox.TabIndex = 31;
            this.ItemListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxDragDrop);
            this.ItemListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxDragEnter);
            // 
            // ConvertLabel
            // 
            this.ConvertLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConvertLabel.AutoSize = true;
            this.ConvertLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.ConvertLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertLabel.Enabled = false;
            this.ConvertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertLabel.Location = new System.Drawing.Point(288, 546);
            this.ConvertLabel.Name = "ConvertLabel";
            this.ConvertLabel.Size = new System.Drawing.Size(79, 20);
            this.ConvertLabel.TabIndex = 30;
            this.ConvertLabel.Text = "convert to";
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OutputLabel.Location = new System.Drawing.Point(438, 23);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(151, 16);
            this.OutputLabel.TabIndex = 29;
            this.OutputLabel.Text = "Dateipfad der Ausgabe:";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.InputLabel.Location = new System.Drawing.Point(79, 23);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(160, 16);
            this.InputLabel.TabIndex = 28;
            this.InputLabel.Text = "Ausgansdatei hinzufügen:";
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Location = new System.Drawing.Point(441, 42);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(221, 20);
            this.OutputBox.TabIndex = 25;
            this.OutputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutputBoxKeyDown);
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBox.Location = new System.Drawing.Point(82, 42);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(221, 20);
            this.InputBox.TabIndex = 24;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBoxKeyDown);
            // 
            // OpenOutput
            // 
            this.OpenOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OpenOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenOutput.Image = global::MP4toMP3Converter.Properties.Resources.folder_2_open_512;
            this.OpenOutput.Location = new System.Drawing.Point(668, 42);
            this.OpenOutput.Name = "OpenOutput";
            this.OpenOutput.Size = new System.Drawing.Size(28, 20);
            this.OpenOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenOutput.TabIndex = 33;
            this.OpenOutput.TabStop = false;
            this.OpenOutput.Click += new System.EventHandler(this.OutputBoxClick);
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConvertButton.Location = new System.Drawing.Point(0, 532);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(760, 48);
            this.ConvertButton.TabIndex = 27;
            this.ConvertButton.TabStop = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButtonClick);
            // 
            // OpenInput
            // 
            this.OpenInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OpenInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenInput.Image = global::MP4toMP3Converter.Properties.Resources.folder_2_open_512;
            this.OpenInput.Location = new System.Drawing.Point(309, 42);
            this.OpenInput.Name = "OpenInput";
            this.OpenInput.Size = new System.Drawing.Size(28, 20);
            this.OpenInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenInput.TabIndex = 26;
            this.OpenInput.TabStop = false;
            this.OpenInput.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // FormDragControl
            // 
            this.FormDragControl.Fixed = true;
            this.FormDragControl.Horizontal = true;
            this.FormDragControl.TargetControl = this;
            this.FormDragControl.Vertical = true;
            // 
            // OutputLabelDragControl
            // 
            this.OutputLabelDragControl.Fixed = true;
            this.OutputLabelDragControl.Horizontal = true;
            this.OutputLabelDragControl.TargetControl = this.OutputLabel;
            this.OutputLabelDragControl.Vertical = true;
            // 
            // InputLabelDragControl
            // 
            this.InputLabelDragControl.Fixed = true;
            this.InputLabelDragControl.Horizontal = true;
            this.InputLabelDragControl.TargetControl = this.InputLabel;
            this.InputLabelDragControl.Vertical = true;
            // 
            // DragDropLabelDragControl
            // 
            this.DragDropLabelDragControl.Fixed = true;
            this.DragDropLabelDragControl.Horizontal = true;
            this.DragDropLabelDragControl.TargetControl = this.DragDropLabel;
            this.DragDropLabelDragControl.Vertical = true;
            // 
            // ItemListBoxDragControl
            // 
            this.ItemListBoxDragControl.Fixed = true;
            this.ItemListBoxDragControl.Horizontal = true;
            this.ItemListBoxDragControl.TargetControl = this.ItemListBox;
            this.ItemListBoxDragControl.Vertical = true;
            // 
            // formatDropdown
            // 
            this.formatDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formatDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.formatDropdown.Cursor = System.Windows.Forms.Cursors.Default;
            this.formatDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatDropdown.ForeColor = System.Drawing.Color.Purple;
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
            this.formatDropdown.Location = new System.Drawing.Point(366, 546);
            this.formatDropdown.Name = "formatDropdown";
            this.formatDropdown.Size = new System.Drawing.Size(69, 24);
            this.formatDropdown.TabIndex = 34;
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(760, 580);
            this.Controls.Add(this.formatDropdown);
            this.Controls.Add(this.OpenOutput);
            this.Controls.Add(this.DragDropLabel);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.ConvertLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OpenInput);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.InputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(760, 580);
            this.MinimumSize = new System.Drawing.Size(760, 580);
            this.Name = "ConvertForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpenOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DragDropLabel;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label ConvertLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.PictureBox ConvertButton;
        private System.Windows.Forms.PictureBox OpenInput;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.PictureBox OpenOutput;
        private Bunifu.Framework.UI.BunifuDragControl FormDragControl;
        private Bunifu.Framework.UI.BunifuDragControl OutputLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl InputLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragDropLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl ItemListBoxDragControl;
        private System.Windows.Forms.ComboBox formatDropdown;
    }
}