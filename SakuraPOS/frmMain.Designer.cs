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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.spltCategoryItems = new System.Windows.Forms.SplitContainer();
            this.pnlMenuTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.spltItemsCart = new System.Windows.Forms.SplitContainer();
            this.pnlMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.spltCartTotal = new System.Windows.Forms.SplitContainer();
            this.grpbxCart = new System.Windows.Forms.GroupBox();
            this.lstbxCurrentCart = new System.Windows.Forms.CheckedListBox();
            this.pnlRegisterOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.strpTopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strpBottomStatus = new System.Windows.Forms.StatusStrip();
            this.strpBottomTimestamp = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.spltCategoryItems)).BeginInit();
            this.spltCategoryItems.Panel1.SuspendLayout();
            this.spltCategoryItems.Panel2.SuspendLayout();
            this.spltCategoryItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltItemsCart)).BeginInit();
            this.spltItemsCart.Panel1.SuspendLayout();
            this.spltItemsCart.Panel2.SuspendLayout();
            this.spltItemsCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltCartTotal)).BeginInit();
            this.spltCartTotal.Panel1.SuspendLayout();
            this.spltCartTotal.Panel2.SuspendLayout();
            this.spltCartTotal.SuspendLayout();
            this.grpbxCart.SuspendLayout();
            this.pnlRegisterOptions.SuspendLayout();
            this.strpTopMenu.SuspendLayout();
            this.strpBottomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltCategoryItems
            // 
            this.spltCategoryItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltCategoryItems.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltCategoryItems.IsSplitterFixed = true;
            this.spltCategoryItems.Location = new System.Drawing.Point(0, 24);
            this.spltCategoryItems.Name = "spltCategoryItems";
            // 
            // spltCategoryItems.Panel1
            // 
            this.spltCategoryItems.Panel1.Controls.Add(this.pnlMenuTypes);
            // 
            // spltCategoryItems.Panel2
            // 
            this.spltCategoryItems.Panel2.Controls.Add(this.spltItemsCart);
            this.spltCategoryItems.Size = new System.Drawing.Size(996, 501);
            this.spltCategoryItems.SplitterDistance = 266;
            this.spltCategoryItems.TabIndex = 0;
            // 
            // pnlMenuTypes
            // 
            this.pnlMenuTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuTypes.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuTypes.Name = "pnlMenuTypes";
            this.pnlMenuTypes.Size = new System.Drawing.Size(266, 501);
            this.pnlMenuTypes.TabIndex = 0;
            // 
            // spltItemsCart
            // 
            this.spltItemsCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltItemsCart.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltItemsCart.Location = new System.Drawing.Point(0, 0);
            this.spltItemsCart.Name = "spltItemsCart";
            // 
            // spltItemsCart.Panel1
            // 
            this.spltItemsCart.Panel1.Controls.Add(this.pnlMenuItems);
            // 
            // spltItemsCart.Panel2
            // 
            this.spltItemsCart.Panel2.Controls.Add(this.spltCartTotal);
            this.spltItemsCart.Size = new System.Drawing.Size(726, 501);
            this.spltItemsCart.SplitterDistance = 442;
            this.spltItemsCart.TabIndex = 1;
            // 
            // pnlMenuItems
            // 
            this.pnlMenuItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuItems.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuItems.Name = "pnlMenuItems";
            this.pnlMenuItems.Size = new System.Drawing.Size(442, 501);
            this.pnlMenuItems.TabIndex = 0;
            // 
            // spltCartTotal
            // 
            this.spltCartTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltCartTotal.Location = new System.Drawing.Point(0, 0);
            this.spltCartTotal.Name = "spltCartTotal";
            this.spltCartTotal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltCartTotal.Panel1
            // 
            this.spltCartTotal.Panel1.Controls.Add(this.grpbxCart);
            // 
            // spltCartTotal.Panel2
            // 
            this.spltCartTotal.Panel2.Controls.Add(this.pnlRegisterOptions);
            this.spltCartTotal.Size = new System.Drawing.Size(280, 501);
            this.spltCartTotal.SplitterDistance = 250;
            this.spltCartTotal.TabIndex = 1;
            // 
            // grpbxCart
            // 
            this.grpbxCart.Controls.Add(this.lstbxCurrentCart);
            this.grpbxCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbxCart.Location = new System.Drawing.Point(0, 0);
            this.grpbxCart.Name = "grpbxCart";
            this.grpbxCart.Size = new System.Drawing.Size(280, 250);
            this.grpbxCart.TabIndex = 0;
            this.grpbxCart.TabStop = false;
            this.grpbxCart.Text = "Cart";
            // 
            // lstbxCurrentCart
            // 
            this.lstbxCurrentCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbxCurrentCart.FormattingEnabled = true;
            this.lstbxCurrentCart.Location = new System.Drawing.Point(3, 19);
            this.lstbxCurrentCart.Name = "lstbxCurrentCart";
            this.lstbxCurrentCart.Size = new System.Drawing.Size(274, 228);
            this.lstbxCurrentCart.TabIndex = 0;
            // 
            // pnlRegisterOptions
            // 
            this.pnlRegisterOptions.Controls.Add(this.btnRemoveItem);
            this.pnlRegisterOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterOptions.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterOptions.Name = "pnlRegisterOptions";
            this.pnlRegisterOptions.Size = new System.Drawing.Size(280, 247);
            this.pnlRegisterOptions.TabIndex = 0;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoveItem.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.NavajoWhite;
            this.btnRemoveItem.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(120, 60);
            this.btnRemoveItem.TabIndex = 0;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // strpTopMenu
            // 
            this.strpTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.strpTopMenu.Location = new System.Drawing.Point(0, 0);
            this.strpTopMenu.Name = "strpTopMenu";
            this.strpTopMenu.Size = new System.Drawing.Size(996, 24);
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
            this.strpBottomStatus.Location = new System.Drawing.Point(0, 503);
            this.strpBottomStatus.Name = "strpBottomStatus";
            this.strpBottomStatus.Size = new System.Drawing.Size(996, 22);
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
            this.ClientSize = new System.Drawing.Size(996, 525);
            this.Controls.Add(this.strpBottomStatus);
            this.Controls.Add(this.spltCategoryItems);
            this.Controls.Add(this.strpTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.strpTopMenu;
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.spltCategoryItems.Panel1.ResumeLayout(false);
            this.spltCategoryItems.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltCategoryItems)).EndInit();
            this.spltCategoryItems.ResumeLayout(false);
            this.spltItemsCart.Panel1.ResumeLayout(false);
            this.spltItemsCart.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltItemsCart)).EndInit();
            this.spltItemsCart.ResumeLayout(false);
            this.spltCartTotal.Panel1.ResumeLayout(false);
            this.spltCartTotal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltCartTotal)).EndInit();
            this.spltCartTotal.ResumeLayout(false);
            this.grpbxCart.ResumeLayout(false);
            this.pnlRegisterOptions.ResumeLayout(false);
            this.strpTopMenu.ResumeLayout(false);
            this.strpTopMenu.PerformLayout();
            this.strpBottomStatus.ResumeLayout(false);
            this.strpBottomStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer spltCategoryItems;
        private FlowLayoutPanel pnlMenuTypes;
        private FlowLayoutPanel pnlMenuItems;
        private MenuStrip strpTopMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem connectToDBToolStripMenuItem;
        private StatusStrip strpBottomStatus;
        private ToolStripStatusLabel strpBottomTimestamp;
        private SplitContainer spltItemsCart;
        private SplitContainer spltCartTotal;
        private GroupBox grpbxCart;
        private FlowLayoutPanel pnlRegisterOptions;
        private CheckedListBox lstbxCurrentCart;
        private Button btnRemoveItem;
    }
}