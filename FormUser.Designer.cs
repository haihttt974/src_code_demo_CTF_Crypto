namespace _3DES
{
    partial class FormUser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chữKýSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mãHoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rC4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.mãHoáToolStripMenuItem,
            this.scanẢnhToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chữKýSốToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(223, 33);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // chữKýSốToolStripMenuItem
            // 
            this.chữKýSốToolStripMenuItem.Name = "chữKýSốToolStripMenuItem";
            this.chữKýSốToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.chữKýSốToolStripMenuItem.Text = "Chữ ký số";
            this.chữKýSốToolStripMenuItem.Click += new System.EventHandler(this.chữKýSốToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // mãHoáToolStripMenuItem
            // 
            this.mãHoáToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aESToolStripMenuItem,
            this.rC4ToolStripMenuItem,
            this.dESToolStripMenuItem});
            this.mãHoáToolStripMenuItem.Name = "mãHoáToolStripMenuItem";
            this.mãHoáToolStripMenuItem.Size = new System.Drawing.Size(107, 33);
            this.mãHoáToolStripMenuItem.Text = "Mã hoá";
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.aESToolStripMenuItem.Text = "RSA";
            this.aESToolStripMenuItem.Click += new System.EventHandler(this.aESToolStripMenuItem_Click);
            // 
            // rC4ToolStripMenuItem
            // 
            this.rC4ToolStripMenuItem.Name = "rC4ToolStripMenuItem";
            this.rC4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rC4ToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.rC4ToolStripMenuItem.Text = "RC4";
            this.rC4ToolStripMenuItem.Click += new System.EventHandler(this.rC4ToolStripMenuItem_Click);
            // 
            // dESToolStripMenuItem
            // 
            this.dESToolStripMenuItem.Name = "dESToolStripMenuItem";
            this.dESToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.dESToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.dESToolStripMenuItem.Text = "3DES";
            this.dESToolStripMenuItem.Click += new System.EventHandler(this.dESToolStripMenuItem_Click);
            // 
            // scanẢnhToolStripMenuItem
            // 
            this.scanẢnhToolStripMenuItem.Name = "scanẢnhToolStripMenuItem";
            this.scanẢnhToolStripMenuItem.Size = new System.Drawing.Size(125, 33);
            this.scanẢnhToolStripMenuItem.Text = "Scan ảnh";
            this.scanẢnhToolStripMenuItem.Click += new System.EventHandler(this.scanẢnhToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(139, 33);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 591);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUser_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mãHoáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rC4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chữKýSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scanẢnhToolStripMenuItem;
    }
}