namespace BinViewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            recentFilesToolStripMenuItem = new ToolStripMenuItem();
            blahToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyAsBinaryToClipboardToolStripMenuItem = new ToolStripMenuItem();
            copyRenderAreaToClipboardToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            resetZoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            viewGridlinesToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            offsetLabel = new Label();
            offsetUpDown = new NumericUpDown();
            bytesPerRowLabel = new Label();
            bytesPerRowUpdown = new NumericUpDown();
            rowsLabel = new Label();
            rowsUpDown = new NumericUpDown();
            openFileDialog = new OpenFileDialog();
            zoomLabel = new Label();
            zoomUpDown = new NumericUpDown();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offsetUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bytesPerRowUpdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rowsUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zoomUpDown).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(623, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, closeToolStripMenuItem, toolStripMenuItem2, recentFilesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            openToolStripMenuItem.Size = new Size(187, 22);
            openToolStripMenuItem.Text = "&Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Enabled = false;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(187, 22);
            closeToolStripMenuItem.Text = "&Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(184, 6);
            // 
            // recentFilesToolStripMenuItem
            // 
            recentFilesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { blahToolStripMenuItem });
            recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            recentFilesToolStripMenuItem.Size = new Size(187, 22);
            recentFilesToolStripMenuItem.Text = "Recent &Files";
            recentFilesToolStripMenuItem.Visible = false;
            // 
            // blahToolStripMenuItem
            // 
            blahToolStripMenuItem.Name = "blahToolStripMenuItem";
            blahToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D1;
            blahToolStripMenuItem.Size = new Size(180, 22);
            blahToolStripMenuItem.Text = "Blah";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyAsBinaryToClipboardToolStripMenuItem, copyRenderAreaToClipboardToolStripMenuItem });
            editToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            editToolStripMenuItem.Size = new Size(39, 22);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // copyAsBinaryToClipboardToolStripMenuItem
            // 
            copyAsBinaryToClipboardToolStripMenuItem.Name = "copyAsBinaryToClipboardToolStripMenuItem";
            copyAsBinaryToClipboardToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            copyAsBinaryToClipboardToolStripMenuItem.Size = new Size(276, 22);
            copyAsBinaryToClipboardToolStripMenuItem.Text = "Copy as &Binary to clipboard..";
            copyAsBinaryToClipboardToolStripMenuItem.Click += copyAsBinaryToClipboardToolStripMenuItem_Click;
            // 
            // copyRenderAreaToClipboardToolStripMenuItem
            // 
            copyRenderAreaToClipboardToolStripMenuItem.Name = "copyRenderAreaToClipboardToolStripMenuItem";
            copyRenderAreaToClipboardToolStripMenuItem.ShortcutKeyDisplayString = "";
            copyRenderAreaToClipboardToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyRenderAreaToClipboardToolStripMenuItem.Size = new Size(276, 22);
            copyRenderAreaToClipboardToolStripMenuItem.Text = "Copy &Render area to clipboard";
            copyRenderAreaToClipboardToolStripMenuItem.Click += copyRenderAreaToClipboardToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetZoomToolStripMenuItem, zoomInToolStripMenuItem, zoomOutToolStripMenuItem, toolStripMenuItem1, viewGridlinesToolStripMenuItem });
            viewToolStripMenuItem.Enabled = false;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 22);
            viewToolStripMenuItem.Text = "&View";
            // 
            // resetZoomToolStripMenuItem
            // 
            resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            resetZoomToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Delete;
            resetZoomToolStripMenuItem.Size = new Size(207, 22);
            resetZoomToolStripMenuItem.Text = "&Reset zoom";
            resetZoomToolStripMenuItem.Click += resetZoomToolStripMenuItem_Click;
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Enabled = false;
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Add;
            zoomInToolStripMenuItem.Size = new Size(207, 22);
            zoomInToolStripMenuItem.Text = "Zoom &In";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Enabled = false;
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Subtract;
            zoomOutToolStripMenuItem.Size = new Size(207, 22);
            zoomOutToolStripMenuItem.Text = "Zoom &Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(204, 6);
            // 
            // viewGridlinesToolStripMenuItem
            // 
            viewGridlinesToolStripMenuItem.Name = "viewGridlinesToolStripMenuItem";
            viewGridlinesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            viewGridlinesToolStripMenuItem.Size = new Size(207, 22);
            viewGridlinesToolStripMenuItem.Text = "&Gridlines";
            viewGridlinesToolStripMenuItem.Click += gridlinesToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(8, 57);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 207);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // offsetLabel
            // 
            offsetLabel.AutoSize = true;
            offsetLabel.Location = new Point(10, 28);
            offsetLabel.Margin = new Padding(2, 0, 2, 0);
            offsetLabel.Name = "offsetLabel";
            offsetLabel.Size = new Size(69, 15);
            offsetLabel.TabIndex = 1;
            offsetLabel.Text = "&Offset (hex)";
            // 
            // offsetUpDown
            // 
            offsetUpDown.Enabled = false;
            offsetUpDown.Hexadecimal = true;
            offsetUpDown.Location = new Point(87, 28);
            offsetUpDown.Margin = new Padding(2);
            offsetUpDown.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            offsetUpDown.Name = "offsetUpDown";
            offsetUpDown.Size = new Size(92, 23);
            offsetUpDown.TabIndex = 2;
            offsetUpDown.ValueChanged += offsetUpDown_ValueChanged;
            offsetUpDown.KeyDown += offsetUpDown_KeyDown;
            // 
            // bytesPerRowLabel
            // 
            bytesPerRowLabel.AutoSize = true;
            bytesPerRowLabel.Location = new Point(197, 28);
            bytesPerRowLabel.Margin = new Padding(2, 0, 2, 0);
            bytesPerRowLabel.Name = "bytesPerRowLabel";
            bytesPerRowLabel.Size = new Size(78, 15);
            bytesPerRowLabel.TabIndex = 3;
            bytesPerRowLabel.Text = "&Bytes per row";
            // 
            // bytesPerRowUpdown
            // 
            bytesPerRowUpdown.Enabled = false;
            bytesPerRowUpdown.Location = new Point(285, 28);
            bytesPerRowUpdown.Margin = new Padding(2);
            bytesPerRowUpdown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            bytesPerRowUpdown.Name = "bytesPerRowUpdown";
            bytesPerRowUpdown.Size = new Size(63, 23);
            bytesPerRowUpdown.TabIndex = 4;
            bytesPerRowUpdown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            bytesPerRowUpdown.ValueChanged += bytesPerRowUpdown_ValueChanged;
            // 
            // rowsLabel
            // 
            rowsLabel.AutoSize = true;
            rowsLabel.Location = new Point(372, 29);
            rowsLabel.Margin = new Padding(2, 0, 2, 0);
            rowsLabel.Name = "rowsLabel";
            rowsLabel.Size = new Size(35, 15);
            rowsLabel.TabIndex = 5;
            rowsLabel.Text = "&Rows";
            // 
            // rowsUpDown
            // 
            rowsUpDown.Enabled = false;
            rowsUpDown.Location = new Point(414, 29);
            rowsUpDown.Margin = new Padding(2);
            rowsUpDown.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            rowsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rowsUpDown.Name = "rowsUpDown";
            rowsUpDown.Size = new Size(57, 23);
            rowsUpDown.TabIndex = 6;
            rowsUpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            rowsUpDown.ValueChanged += rowsUpDown_ValueChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "*.*";
            openFileDialog.FileName = "*.*";
            // 
            // zoomLabel
            // 
            zoomLabel.AutoSize = true;
            zoomLabel.Location = new Point(507, 32);
            zoomLabel.Margin = new Padding(2, 0, 2, 0);
            zoomLabel.Name = "zoomLabel";
            zoomLabel.Size = new Size(39, 15);
            zoomLabel.TabIndex = 7;
            zoomLabel.Text = "&Zoom";
            // 
            // zoomUpDown
            // 
            zoomUpDown.Enabled = false;
            zoomUpDown.Location = new Point(550, 29);
            zoomUpDown.Margin = new Padding(2);
            zoomUpDown.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            zoomUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            zoomUpDown.Name = "zoomUpDown";
            zoomUpDown.Size = new Size(57, 23);
            zoomUpDown.TabIndex = 8;
            zoomUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            zoomUpDown.ValueChanged += zoomUpDown_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 270);
            Controls.Add(zoomUpDown);
            Controls.Add(zoomLabel);
            Controls.Add(rowsUpDown);
            Controls.Add(rowsLabel);
            Controls.Add(bytesPerRowUpdown);
            Controls.Add(bytesPerRowLabel);
            Controls.Add(offsetUpDown);
            Controls.Add(offsetLabel);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)offsetUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)bytesPerRowUpdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rowsUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)zoomUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem resetZoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label offsetLabel;
        private NumericUpDown offsetUpDown;
        private Label bytesPerRowLabel;
        private NumericUpDown bytesPerRowUpdown;
        private Label rowsLabel;
        private NumericUpDown rowsUpDown;
        private OpenFileDialog openFileDialog;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem copyRenderAreaToClipboardToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem copyAsBinaryToClipboardToolStripMenuItem;
        private Label zoomLabel;
        private NumericUpDown zoomUpDown;
        private ToolStripMenuItem viewGridlinesToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem recentFilesToolStripMenuItem;
        private ToolStripMenuItem blahToolStripMenuItem;
    }
}