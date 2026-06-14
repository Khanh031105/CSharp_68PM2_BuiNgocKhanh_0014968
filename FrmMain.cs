namespace QLSV
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuSinhVien;
        private ToolStripMenuItem menuLopHoc;
        private ToolStripMenuItem menuDangXuat;
        private Panel panelContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuSinhVien = new ToolStripMenuItem();
            menuLopHoc = new ToolStripMenuItem();
            menuDangXuat = new ToolStripMenuItem();
            panelContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();

            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSinhVien, menuLopHoc, menuDangXuat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1500, 28);

            menuSinhVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuSinhVien.Text = "Quản Lý Sinh Viên";
            menuSinhVien.Click += menuSinhVien_Click;

            menuLopHoc.Text = "Quản Lý Lớp Học";
            menuLopHoc.Click += menuLopHoc_Click;

            menuDangXuat.ForeColor = Color.Crimson;
            menuDangXuat.Text = "Đăng xuất";
            menuDangXuat.Click += menuDangXuat_Click;

            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 28);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1500, 872);

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 900);
            Controls.Add(panelContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
