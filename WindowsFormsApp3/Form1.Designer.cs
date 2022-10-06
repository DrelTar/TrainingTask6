namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Format2 = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Bold = new System.Windows.Forms.ToolStripMenuItem();
            this.Italic = new System.Windows.Forms.ToolStripMenuItem();
            this.Underline = new System.Windows.Forms.ToolStripMenuItem();
            this.Strikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.Regular = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AutosavingTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.AutosavingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AutosavingNever = new System.Windows.Forms.ToolStripMenuItem();
            this.Autosaving30sec = new System.Windows.Forms.ToolStripMenuItem();
            this.Autosaving1min = new System.Windows.Forms.ToolStripMenuItem();
            this.Autosaving5min = new System.Windows.Forms.ToolStripMenuItem();
            this.Autosaving15min = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.FileMenu.SuspendLayout();
            this.EditMenu.SuspendLayout();
            this.FormatMenu.SuspendLayout();
            this.SettingsMenu.SuspendLayout();
            this.AutosavingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Format,
            this.Settings});
            this.menuStrip.Location = new System.Drawing.Point(12, 9);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(249, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // File
            // 
            this.File.DropDown = this.FileMenu;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 24);
            this.File.Text = "&File";
            // 
            // FileMenu
            // 
            this.FileMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.toolStripSeparator2,
            this.New,
            this.toolStripSeparator1,
            this.Save,
            this.SaveAs});
            this.FileMenu.Name = "contextMenuStrip1";
            this.FileMenu.OwnerItem = this.File;
            this.FileMenu.Size = new System.Drawing.Size(128, 112);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(127, 24);
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(127, 24);
            this.New.Text = "New";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(127, 24);
            this.Save.Text = "Save";
            // 
            // SaveAs
            // 
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(127, 24);
            this.SaveAs.Text = "Save as";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // Edit
            // 
            this.Edit.DropDown = this.EditMenu;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(49, 24);
            this.Edit.Text = "Edit";
            // 
            // EditMenu
            // 
            this.EditMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAll,
            this.Cut,
            this.Copy,
            this.Paste,
            this.Format2});
            this.EditMenu.Name = "RightClickMenu";
            this.EditMenu.OwnerItem = this.Edit;
            this.EditMenu.Size = new System.Drawing.Size(139, 124);
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(138, 24);
            this.SelectAll.Text = "Select all";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // Cut
            // 
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(138, 24);
            this.Cut.Text = "Cut";
            this.Cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Copy
            // 
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(138, 24);
            this.Copy.Text = "Copy";
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Paste
            // 
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(138, 24);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // Format2
            // 
            this.Format2.DropDown = this.FormatMenu;
            this.Format2.Name = "Format2";
            this.Format2.Size = new System.Drawing.Size(138, 24);
            this.Format2.Text = "Format";
            // 
            // FormatMenu
            // 
            this.FormatMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FormatMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bold,
            this.Italic,
            this.Underline,
            this.Strikeout,
            this.Regular});
            this.FormatMenu.Name = "contextMenuStrip2";
            this.FormatMenu.OwnerItem = this.Format;
            this.FormatMenu.Size = new System.Drawing.Size(143, 124);
            // 
            // Bold
            // 
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(142, 24);
            this.Bold.Text = "Bold";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(142, 24);
            this.Italic.Text = "Italic";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(142, 24);
            this.Underline.Text = "Underline";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // Strikeout
            // 
            this.Strikeout.Name = "Strikeout";
            this.Strikeout.Size = new System.Drawing.Size(142, 24);
            this.Strikeout.Text = "Strikeout";
            this.Strikeout.Click += new System.EventHandler(this.Strikeout_Click);
            // 
            // Regular
            // 
            this.Regular.Name = "Regular";
            this.Regular.Size = new System.Drawing.Size(142, 24);
            this.Regular.Text = "Regular";
            this.Regular.Click += new System.EventHandler(this.Regular_Click);
            // 
            // Format
            // 
            this.Format.DropDown = this.FormatMenu;
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(70, 24);
            this.Format.Text = "Format";
            // 
            // Settings
            // 
            this.Settings.DropDown = this.SettingsMenu;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(76, 24);
            this.Settings.Text = "Settings";
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SettingsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutosavingTitle});
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.OwnerItem = this.Settings;
            this.SettingsMenu.Size = new System.Drawing.Size(187, 28);
            // 
            // AutosavingTitle
            // 
            this.AutosavingTitle.DropDown = this.AutosavingMenu;
            this.AutosavingTitle.Name = "AutosavingTitle";
            this.AutosavingTitle.Size = new System.Drawing.Size(186, 24);
            this.AutosavingTitle.Text = "Autosaving time";
            // 
            // AutosavingMenu
            // 
            this.AutosavingMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AutosavingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutosavingNever,
            this.Autosaving30sec,
            this.Autosaving1min,
            this.Autosaving5min,
            this.Autosaving15min});
            this.AutosavingMenu.Name = "contextMenuStrip1";
            this.AutosavingMenu.OwnerItem = this.AutosavingTitle;
            this.AutosavingMenu.Size = new System.Drawing.Size(124, 134);
            // 
            // AutosavingNever
            // 
            this.AutosavingNever.Name = "AutosavingNever";
            this.AutosavingNever.Size = new System.Drawing.Size(123, 26);
            this.AutosavingNever.Text = "Never";
            this.AutosavingNever.Click += new System.EventHandler(this.AutosavingNever_Click);
            // 
            // Autosaving30sec
            // 
            this.Autosaving30sec.Name = "Autosaving30sec";
            this.Autosaving30sec.Size = new System.Drawing.Size(123, 26);
            this.Autosaving30sec.Text = "30 sec";
            this.Autosaving30sec.Click += new System.EventHandler(this.Autosaving30sec_Click);
            // 
            // Autosaving1min
            // 
            this.Autosaving1min.Name = "Autosaving1min";
            this.Autosaving1min.Size = new System.Drawing.Size(123, 26);
            this.Autosaving1min.Text = "1 min";
            this.Autosaving1min.Click += new System.EventHandler(this.Autosaving1min_Click);
            // 
            // Autosaving5min
            // 
            this.Autosaving5min.Checked = true;
            this.Autosaving5min.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Autosaving5min.Name = "Autosaving5min";
            this.Autosaving5min.Size = new System.Drawing.Size(123, 26);
            this.Autosaving5min.Text = "5 min";
            this.Autosaving5min.Click += new System.EventHandler(this.Autosaving5min_Click);
            // 
            // Autosaving15min
            // 
            this.Autosaving15min.Name = "Autosaving15min";
            this.Autosaving15min.Size = new System.Drawing.Size(123, 26);
            this.Autosaving15min.Text = "15 min";
            this.Autosaving15min.Click += new System.EventHandler(this.Autosaving15min_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files|*.txt|RTF|*.rtf|C# files|*.cs";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files|*.txt|RTF|*.rtf|C# files|*.cs";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(12, 40);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(768, 398);
            this.tabControl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.FileMenu.ResumeLayout(false);
            this.EditMenu.ResumeLayout(false);
            this.FormatMenu.ResumeLayout(false);
            this.SettingsMenu.ResumeLayout(false);
            this.AutosavingMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ContextMenuStrip FileMenu;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem SaveAs;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ContextMenuStrip FormatMenu;
        private System.Windows.Forms.ToolStripMenuItem Bold;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Italic;
        private System.Windows.Forms.ToolStripMenuItem Underline;
        private System.Windows.Forms.ToolStripMenuItem Strikeout;
        private System.Windows.Forms.ToolStripMenuItem Regular;
        private System.Windows.Forms.ContextMenuStrip SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem AutosavingTitle;
        private System.Windows.Forms.ContextMenuStrip AutosavingMenu;
        private System.Windows.Forms.ToolStripMenuItem AutosavingNever;
        private System.Windows.Forms.ToolStripMenuItem Autosaving30sec;
        private System.Windows.Forms.ToolStripMenuItem Autosaving1min;
        private System.Windows.Forms.ToolStripMenuItem Autosaving5min;
        private System.Windows.Forms.ToolStripMenuItem Autosaving15min;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip EditMenu;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripMenuItem Cut;
        private System.Windows.Forms.ToolStripMenuItem Copy;
        private System.Windows.Forms.ToolStripMenuItem Paste;
        private System.Windows.Forms.ToolStripMenuItem Format2;
    }
}

