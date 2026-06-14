using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_password.PasswordChar = '*';

            TestConnection();
        }

        private void TestConnection()
        {
            Database db = new Database();

            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Kết nối database thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (username == "0014968@st.huce.edu.vn" && password == "0014968")
            {
                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}