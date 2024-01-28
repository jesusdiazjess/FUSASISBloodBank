namespace BloodBank
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnExit = new XanderUI.XUIButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dONORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHBLOODDONORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRASEDONORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ButtonImage")));
            this.btnExit.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.btnExit.ButtonText = "EXIT";
            this.btnExit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnExit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.CornerRadius = 5;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnExit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExit.Location = new System.Drawing.Point(1292, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dONORToolStripMenuItem,
            this.sEARCHBLOODDONORToolStripMenuItem,
            this.eRASEDONORToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1375, 68);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dONORToolStripMenuItem
            // 
            this.dONORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDonorToolStripMenuItem,
            this.allDetailsToolStripMenuItem});
            this.dONORToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dONORToolStripMenuItem.Image")));
            this.dONORToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dONORToolStripMenuItem.Name = "dONORToolStripMenuItem";
            this.dONORToolStripMenuItem.Size = new System.Drawing.Size(143, 64);
            this.dONORToolStripMenuItem.Text = "DONOR";
            // 
            // addNewDonorToolStripMenuItem
            // 
            this.addNewDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDonorToolStripMenuItem.Image")));
            this.addNewDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDonorToolStripMenuItem.Name = "addNewDonorToolStripMenuItem";
            this.addNewDonorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addNewDonorToolStripMenuItem.Text = "Add New Donor";
            this.addNewDonorToolStripMenuItem.Click += new System.EventHandler(this.addNewDonorToolStripMenuItem_Click);
            // 
            // allDetailsToolStripMenuItem
            // 
            this.allDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("allDetailsToolStripMenuItem.Image")));
            this.allDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.allDetailsToolStripMenuItem.Name = "allDetailsToolStripMenuItem";
            this.allDetailsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.allDetailsToolStripMenuItem.Text = "All Details";
            this.allDetailsToolStripMenuItem.Click += new System.EventHandler(this.allDetailsToolStripMenuItem_Click);
            // 
            // sEARCHBLOODDONORToolStripMenuItem
            // 
            this.sEARCHBLOODDONORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloodGroupToolStripMenuItem});
            this.sEARCHBLOODDONORToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sEARCHBLOODDONORToolStripMenuItem.Image")));
            this.sEARCHBLOODDONORToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sEARCHBLOODDONORToolStripMenuItem.Name = "sEARCHBLOODDONORToolStripMenuItem";
            this.sEARCHBLOODDONORToolStripMenuItem.Size = new System.Drawing.Size(144, 64);
            this.sEARCHBLOODDONORToolStripMenuItem.Text = "SEARCH";
            this.sEARCHBLOODDONORToolStripMenuItem.Click += new System.EventHandler(this.sEARCHBLOODDONORToolStripMenuItem_Click);
            // 
            // bloodGroupToolStripMenuItem
            // 
            this.bloodGroupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bloodGroupToolStripMenuItem.Image")));
            this.bloodGroupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bloodGroupToolStripMenuItem.Name = "bloodGroupToolStripMenuItem";
            this.bloodGroupToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.bloodGroupToolStripMenuItem.Text = "Blood Location";
            this.bloodGroupToolStripMenuItem.Click += new System.EventHandler(this.bloodGroupToolStripMenuItem_Click);
            // 
            // eRASEDONORToolStripMenuItem
            // 
            this.eRASEDONORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDonorToolStripMenuItem});
            this.eRASEDONORToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eRASEDONORToolStripMenuItem.Image")));
            this.eRASEDONORToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eRASEDONORToolStripMenuItem.Name = "eRASEDONORToolStripMenuItem";
            this.eRASEDONORToolStripMenuItem.Size = new System.Drawing.Size(129, 64);
            this.eRASEDONORToolStripMenuItem.Text = "ERASE";
            // 
            // deleteDonorToolStripMenuItem
            // 
            this.deleteDonorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteDonorToolStripMenuItem.Image")));
            this.deleteDonorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteDonorToolStripMenuItem.Name = "deleteDonorToolStripMenuItem";
            this.deleteDonorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteDonorToolStripMenuItem.Text = "Delete Donor";
            this.deleteDonorToolStripMenuItem.Click += new System.EventHandler(this.deleteDonorToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lOGOUTToolStripMenuItem.Image")));
            this.lOGOUTToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(161, 64);
            this.lOGOUTToolStripMenuItem.Text = "LOG OUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1375, 728);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dONORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEARCHBLOODDONORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRASEDONORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDonorToolStripMenuItem;
    }
}