﻿namespace TUTORIALS.ParentForm
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDumb3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDumb4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDumb5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDumb6 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListParent = new System.Windows.Forms.ImageList(this.components);
            this.toolStripParent = new System.Windows.Forms.ToolStrip();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDumb1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDumb2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuDumb1,
            this.menuDumb2,
            this.menuWindow});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.MdiWindowListItem = this.menuWindow;
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(584, 24);
            this.menuMain.TabIndex = 1;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.toolStripSeparator2,
            this.menuExit,
            this.menuDumb3,
            this.menuDumb4,
            this.menuDumb5,
            this.menuDumb6});
            this.menuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuFile.MergeIndex = 0;
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuNew.MergeIndex = 0;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(152, 22);
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.menuOpen.MergeIndex = 1;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(152, 22);
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.toolStripSeparator2.MergeIndex = 2;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menuExit
            // 
            this.menuExit.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.menuExit.MergeIndex = 7;
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuDumb3
            // 
            this.menuDumb3.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.menuDumb3.MergeIndex = 3;
            this.menuDumb3.Name = "menuDumb3";
            this.menuDumb3.Size = new System.Drawing.Size(152, 22);
            this.menuDumb3.Text = "3";
            this.menuDumb3.Visible = false;
            // 
            // menuDumb4
            // 
            this.menuDumb4.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.menuDumb4.MergeIndex = 4;
            this.menuDumb4.Name = "menuDumb4";
            this.menuDumb4.Size = new System.Drawing.Size(152, 22);
            this.menuDumb4.Text = "4";
            this.menuDumb4.Visible = false;
            // 
            // menuDumb5
            // 
            this.menuDumb5.MergeIndex = 5;
            this.menuDumb5.Name = "menuDumb5";
            this.menuDumb5.Size = new System.Drawing.Size(152, 22);
            this.menuDumb5.Text = "5";
            this.menuDumb5.Visible = false;
            // 
            // menuDumb6
            // 
            this.menuDumb6.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.menuDumb6.MergeIndex = 6;
            this.menuDumb6.Name = "menuDumb6";
            this.menuDumb6.Size = new System.Drawing.Size(152, 22);
            this.menuDumb6.Text = "6";
            this.menuDumb6.Visible = false;
            // 
            // imageListParent
            // 
            this.imageListParent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListParent.ImageStream")));
            this.imageListParent.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListParent.Images.SetKeyName(0, "new.png");
            this.imageListParent.Images.SetKeyName(1, "open.png");
            this.imageListParent.Images.SetKeyName(2, "save.jpg");
            this.imageListParent.Images.SetKeyName(3, "previous.png");
            this.imageListParent.Images.SetKeyName(4, "next.png");
            // 
            // toolStripParent
            // 
            this.toolStripParent.Location = new System.Drawing.Point(0, 24);
            this.toolStripParent.Name = "toolStripParent";
            this.toolStripParent.Size = new System.Drawing.Size(584, 25);
            this.toolStripParent.TabIndex = 3;
            this.toolStripParent.Visible = false;
            this.toolStripParent.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripParent_ItemClicked);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconsToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.menuWindow.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.menuWindow.MergeIndex = 3;
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(63, 20);
            this.menuWindow.Text = "&Window";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // menuDumb1
            // 
            this.menuDumb1.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.menuDumb1.MergeIndex = 1;
            this.menuDumb1.Name = "menuDumb1";
            this.menuDumb1.Size = new System.Drawing.Size(25, 20);
            this.menuDumb1.Text = "1";
            this.menuDumb1.Visible = false;
            // 
            // menuDumb2
            // 
            this.menuDumb2.MergeAction = System.Windows.Forms.MergeAction.Remove;
            this.menuDumb2.MergeIndex = 2;
            this.menuDumb2.Name = "menuDumb2";
            this.menuDumb2.Size = new System.Drawing.Size(25, 20);
            this.menuDumb2.Text = "2";
            this.menuDumb2.Visible = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.toolStripParent);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.ParentForm_MdiChildActivate);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuDumb3;
        private System.Windows.Forms.ToolStripMenuItem menuDumb4;
        private System.Windows.Forms.ToolStripMenuItem menuDumb5;
        private System.Windows.Forms.ToolStripMenuItem menuDumb6;
        private System.Windows.Forms.ImageList imageListParent;
        private System.Windows.Forms.ToolStrip toolStripParent;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDumb1;
        private System.Windows.Forms.ToolStripMenuItem menuDumb2;
    }
}

