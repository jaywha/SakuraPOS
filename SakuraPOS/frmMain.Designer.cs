namespace SakuraPOS
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlMenuTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.strpTopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strpBottomStatus = new System.Windows.Forms.StatusStrip();
            this.strpBottomTimestamp = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.strpTopMenu.SuspendLayout();
            this.strpBottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlMenuTypes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlMenuItems);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlMenuTypes
            // 
            this.pnlMenuTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuTypes.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuTypes.Name = "pnlMenuTypes";
            this.pnlMenuTypes.Size = new System.Drawing.Size(266, 426);
            this.pnlMenuTypes.TabIndex = 0;
            // 
            // pnlMenuItems
            // 
            this.pnlMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuItems.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuItems.Name = "pnlMenuItems";
            this.pnlMenuItems.Size = new System.Drawing.Size(530, 426);
            this.pnlMenuItems.TabIndex = 0;
            // 
            // strpTopMenu
            // 
            this.strpTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.strpTopMenu.Location = new System.Drawing.Point(0, 0);
            this.strpTopMenu.Name = "strpTopMenu";
            this.strpTopMenu.Size = new System.Drawing.Size(800, 24);
            this.strpTopMenu.TabIndex = 1;
            this.strpTopMenu.Text = "Top Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDBToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToDBToolStripMenuItem
            // 
            this.connectToDBToolStripMenuItem.Name = "connectToDBToolStripMenuItem";
            this.connectToDBToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.connectToDBToolStripMenuItem.Text = "Connect to DB...";
            this.connectToDBToolStripMenuItem.Click += new System.EventHandler(this.connectToDBToolStripMenuItem_Click);
            // 
            // strpBottomStatus
            // 
            this.strpBottomStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpBottomTimestamp});
            this.strpBottomStatus.Location = new System.Drawing.Point(0, 428);
            this.strpBottomStatus.Name = "strpBottomStatus";
            this.strpBottomStatus.Size = new System.Drawing.Size(800, 22);
            this.strpBottomStatus.TabIndex = 2;
            this.strpBottomStatus.Text = "statusStrip1";
            // 
            // strpBottomTimestamp
            // 
            this.strpBottomTimestamp.Name = "strpBottomTimestamp";
            this.strpBottomTimestamp.Size = new System.Drawing.Size(31, 17);
            this.strpBottomTimestamp.Text = "time";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strpBottomStatus);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.strpTopMenu);
            this.MainMenuStrip = this.strpTopMenu;
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.strpTopMenu.ResumeLayout(false);
            this.strpTopMenu.PerformLayout();
            this.strpBottomStatus.ResumeLayout(false);
            this.strpBottomStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel pnlMenuTypes;
        private FlowLayoutPanel pnlMenuItems;
        private MenuStrip strpTopMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem connectToDBToolStripMenuItem;
        private StatusStrip strpBottomStatus;
        private ToolStripStatusLabel strpBottomTimestamp;
    }
}