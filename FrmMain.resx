namespace QLSV
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadControl(new QLSinhVien());
        }

        private void menuSinhVien_Click(object sender, EventArgs e)
        {
            LoadControl(new QLSinhVien());
        }

        private void menuLopHoc_Click(object sender, EventArgs e)
        {
            LoadControl(new QLLopHoc());
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void LoadControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }
    }
}
