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
            this.ItemListBoxDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.DragDropLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragDropLabel = new System.Windows.Forms.Label();
            this.InputLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputLabelDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.OutputLabel = new System.Windows.Forms.Label();
            this.FormDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OpenInput = new System.Windows.Forms.PictureBox();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.OpenOutput = new System.Windows.Forms.PictureBox();
            this.ConvertButton = new System.Windows.Forms.PictureBox();
            this.ConvertLabel = new System.Windows.Forms.Label();
            this.formatDropdown = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OpenInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertButton)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ItemListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.ItemListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 20;
            this.ItemListBox.Location = new System.Drawing.Point(10, 9);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(400, 560);
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
            this.DragDropLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragDropLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
            this.DragDropLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.DragDropLabel.Enabled = false;
            this.DragDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragDropLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.DragDropLabel.Location = new System.Drawing.Point(103, 272);
            this.DragDropLabel.Name = "DragDropLabel";
            this.DragDropLabel.Size = new System.Drawing.Size(236, 44);
            this.DragDropLabel.TabIndex = 58;
            this.DragDropLabel.Text = "Drag and Drop here";
            this.DragDropLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.InputLabel.Location = new System.Drawing.Point(18, 32);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(92, 16);
            this.InputLabel.TabIndex = 53;
            this.InputLabel.Text = "Add Input File:";
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
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OutputLabel.Location = new System.Drawing.Point(18, 109);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(114, 16);
            this.OutputLabel.TabIndex = 52;
            this.OutputLabel.Text = "Filepath of Output:";
            // 
            // FormDragControl
            // 
            this.FormDragControl.Fixed = true;
            this.FormDragControl.Horizontal = true;
            this.FormDragControl.TargetControl = this;
            this.FormDragControl.Vertical = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Output format:";
            // 
            // InputBox
            // 
            this.InputBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputBox.Location = new System.Drawing.Point(21, 51);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(221, 20);
            this.InputBox.TabIndex = 48;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBoxKeyDown);
            // 
            // OpenInput
            // 
            this.OpenInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OpenInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenInput.Image = global::MP4toMP3Converter.Properties.Resources.folder_2_open_512;
            this.OpenInput.Location = new System.Drawing.Point(248, 51);
            this.OpenInput.Name = "OpenInput";
            this.OpenInput.Size = new System.Drawing.Size(28, 20);
            this.OpenInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenInput.TabIndex = 49;
            this.OpenInput.TabStop = false;
            this.OpenInput.Click += new System.EventHandler(this.InputBoxClick);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputBox.Location = new System.Drawing.Point(21, 128);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(221, 20);
            this.OutputBox.TabIndex = 50;
            this.OutputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OutputBoxKeyDown);
            // 
            // OpenOutput
            // 
            this.OpenOutput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.OpenOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenOutput.Image = global::MP4toMP3Converter.Properties.Resources.folder_2_open_512;
            this.OpenOutput.Location = new System.Drawing.Point(248, 128);
            this.OpenOutput.Name = "OpenOutput";
            this.OpenOutput.Size = new System.Drawing.Size(28, 20);
            this.OpenOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenOutput.TabIndex = 51;
            this.OpenOutput.TabStop = false;
            this.OpenOutput.Click += new System.EventHandler(this.OutputBoxClick);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertButton.Location = new System.Drawing.Point(12, 505);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(309, 41);
            this.ConvertButton.TabIndex = 55;
            this.ConvertButton.TabStop = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButtonClick);
            // 
            // ConvertLabel
            // 
            this.ConvertLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConvertLabel.AutoSize = true;
            this.ConvertLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.ConvertLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertLabel.Enabled = false;
            this.ConvertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertLabel.ForeColor = System.Drawing.Color.Black;
            this.ConvertLabel.Location = new System.Drawing.Point(138, 516);
            this.ConvertLabel.Name = "ConvertLabel";
            this.ConvertLabel.Size = new System.Drawing.Size(61, 20);
            this.ConvertLabel.TabIndex = 56;
            this.ConvertLabel.Text = "convert";
            // 
            // formatDropdown
            // 
            this.formatDropdown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.formatDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.formatDropdown.Cursor = System.Windows.Forms.Cursors.Default;
            this.formatDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(74)))), ((int)(((byte)(113)))));
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
            this.formatDropdown.Location = new System.Drawing.Point(113, 191);
            this.formatDropdown.Name = "formatDropdown";
            this.formatDropdown.Size = new System.Drawing.Size(69, 24);
            this.formatDropdown.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ConvertLabel);
            this.panel1.Controls.Add(this.formatDropdown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.InputBox);
            this.panel1.Controls.Add(this.ConvertButton);
            this.panel1.Controls.Add(this.OpenInput);
            this.panel1.Controls.Add(this.InputLabel);
            this.panel1.Controls.Add(this.OutputBox);
            this.panel1.Controls.Add(this.OutputLabel);
            this.panel1.Controls.Add(this.OpenOutput);
            this.panel1.Location = new System.Drawing.Point(420, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 559);
            this.panel1.TabIndex = 59;
            // 
            // panel1DragControl
            // 
            this.panel1DragControl.Fixed = true;
            this.panel1DragControl.Horizontal = true;
            this.panel1DragControl.TargetControl = this.panel1;
            this.panel1DragControl.Vertical = true;
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(760, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DragDropLabel);
            this.Controls.Add(this.ItemListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(760, 580);
            this.MinimumSize = new System.Drawing.Size(760, 580);
            this.Name = "ConvertForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.OpenInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl ItemListBoxDragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragDropLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl InputLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl OutputLabelDragControl;
        private Bunifu.Framework.UI.BunifuDragControl FormDragControl;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox OpenOutput;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.PictureBox OpenInput;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.PictureBox ConvertButton;
        private System.Windows.Forms.Label ConvertLabel;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label DragDropLabel;
        private System.Windows.Forms.ComboBox formatDropdown;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl panel1DragControl;
    }
}