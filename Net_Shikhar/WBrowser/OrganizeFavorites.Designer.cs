namespace WBrowser
{
    partial class OrganizeFavorites
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Links");
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.organizeFavTreeView = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.organizeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "हटायें";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "नाम बदलें";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // organizeFavTreeView
            // 
            this.organizeFavTreeView.Location = new System.Drawing.Point(14, 19);
            this.organizeFavTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.organizeFavTreeView.Name = "organizeFavTreeView";
            treeNode1.Name = "Links";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Links";
            this.organizeFavTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.organizeFavTreeView.ShowNodeToolTips = true;
            this.organizeFavTreeView.Size = new System.Drawing.Size(263, 407);
            this.organizeFavTreeView.TabIndex = 4;
            this.organizeFavTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.organizeFavTreeView_NodeMouseClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 395);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "रद्द करें";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // organizeContextMenu
            // 
            this.organizeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.organizeContextMenu.Name = "organizeContextMenu";
            this.organizeContextMenu.Size = new System.Drawing.Size(133, 52);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Font = new System.Drawing.Font("DV-TTYogesh", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.renameToolStripMenuItem.Text = "नाम बदलें";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("DV-TTYogesh", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.deleteToolStripMenuItem.Text = "हटायें";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // OrganizeFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 447);
            this.Controls.Add(this.organizeFavTreeView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("DV-TTYogesh", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "OrganizeFavorites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "पसंदीदा व्यवस्थित करें :";
            this.Load += new System.EventHandler(this.OrganizeFavorites_Load);
            this.organizeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView organizeFavTreeView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip organizeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}