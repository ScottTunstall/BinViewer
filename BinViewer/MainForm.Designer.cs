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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAsBinaryToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRenderAreaToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.offsetUpDown = new System.Windows.Forms.NumericUpDown();
            this.bytesPerRowLabel = new System.Windows.Forms.Label();
            this.bytesPerRowUpdown = new System.Windows.Forms.NumericUpDown();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.rowsUpDown = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bytesPerRowUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Enabled = false;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAsBinaryToClipboardToolStripMenuItem,
            this.copyRenderAreaToClipboardToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyAsBinaryToClipboardToolStripMenuItem
            // 
            this.copyAsBinaryToClipboardToolStripMenuItem.Name = "copyAsBinaryToClipboardToolStripMenuItem";
            this.copyAsBinaryToClipboardToolStripMenuItem.Size = new System.Drawing.Size(414, 34);
            this.copyAsBinaryToClipboardToolStripMenuItem.Text = "Copy as binary to clipboard..";
            this.copyAsBinaryToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyAsBinaryToClipboardToolStripMenuItem_Click);
            // 
            // copyRenderAreaToClipboardToolStripMenuItem
            // 
            this.copyRenderAreaToClipboardToolStripMenuItem.Name = "copyRenderAreaToClipboardToolStripMenuItem";
            this.copyRenderAreaToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyRenderAreaToClipboardToolStripMenuItem.Size = new System.Drawing.Size(414, 34);
            this.copyRenderAreaToClipboardToolStripMenuItem.Text = "Copy render area to clipboard";
            this.copyRenderAreaToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyRenderAreaToClipboardToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetZoomToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Enabled = false;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // resetZoomToolStripMenuItem
            // 
            this.resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            this.resetZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.resetZoomToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.resetZoomToolStripMenuItem.Text = "Reset zoom";
            this.resetZoomToolStripMenuItem.Click += new System.EventHandler(this.resetZoomToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Enabled = false;
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Enabled = false;
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Subtract)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 343);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // offsetLabel
            // 
            this.offsetLabel.AutoSize = true;
            this.offsetLabel.Location = new System.Drawing.Point(15, 47);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(103, 25);
            this.offsetLabel.TabIndex = 1;
            this.offsetLabel.Text = "&Offset (hex)";
            // 
            // offsetUpDown
            // 
            this.offsetUpDown.Enabled = false;
            this.offsetUpDown.Hexadecimal = true;
            this.offsetUpDown.Location = new System.Drawing.Point(124, 47);
            this.offsetUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.offsetUpDown.Name = "offsetUpDown";
            this.offsetUpDown.Size = new System.Drawing.Size(132, 31);
            this.offsetUpDown.TabIndex = 2;
            this.offsetUpDown.ValueChanged += new System.EventHandler(this.offsetUpDown_ValueChanged);
            this.offsetUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.offsetUpDown_KeyDown);
            // 
            // bytesPerRowLabel
            // 
            this.bytesPerRowLabel.AutoSize = true;
            this.bytesPerRowLabel.Location = new System.Drawing.Point(281, 47);
            this.bytesPerRowLabel.Name = "bytesPerRowLabel";
            this.bytesPerRowLabel.Size = new System.Drawing.Size(120, 25);
            this.bytesPerRowLabel.TabIndex = 3;
            this.bytesPerRowLabel.Text = "&Bytes per row";
            // 
            // bytesPerRowUpdown
            // 
            this.bytesPerRowUpdown.Enabled = false;
            this.bytesPerRowUpdown.Location = new System.Drawing.Point(407, 47);
            this.bytesPerRowUpdown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bytesPerRowUpdown.Name = "bytesPerRowUpdown";
            this.bytesPerRowUpdown.Size = new System.Drawing.Size(90, 31);
            this.bytesPerRowUpdown.TabIndex = 4;
            this.bytesPerRowUpdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bytesPerRowUpdown.ValueChanged += new System.EventHandler(this.bytesPerRowUpdown_ValueChanged);
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(532, 49);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(54, 25);
            this.rowsLabel.TabIndex = 5;
            this.rowsLabel.Text = "&Rows";
            // 
            // rowsUpDown
            // 
            this.rowsUpDown.Enabled = false;
            this.rowsUpDown.Location = new System.Drawing.Point(592, 49);
            this.rowsUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.rowsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowsUpDown.Name = "rowsUpDown";
            this.rowsUpDown.Size = new System.Drawing.Size(82, 31);
            this.rowsUpDown.TabIndex = 6;
            this.rowsUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.rowsUpDown.ValueChanged += new System.EventHandler(this.rowsUpDown_ValueChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.*";
            this.openFileDialog.FileName = "*.*";
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(724, 53);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(60, 25);
            this.zoomLabel.TabIndex = 7;
            this.zoomLabel.Text = "&Zoom";
            // 
            // zoomUpDown
            // 
            this.zoomUpDown.Enabled = false;
            this.zoomUpDown.Location = new System.Drawing.Point(781, 51);
            this.zoomUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.zoomUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zoomUpDown.Name = "zoomUpDown";
            this.zoomUpDown.Size = new System.Drawing.Size(82, 31);
            this.zoomUpDown.TabIndex = 8;
            this.zoomUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.zoomUpDown.ValueChanged += new System.EventHandler(this.zoomUpDown_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.zoomUpDown);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.rowsUpDown);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.bytesPerRowUpdown);
            this.Controls.Add(this.bytesPerRowLabel);
            this.Controls.Add(this.offsetUpDown);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bytesPerRowUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}