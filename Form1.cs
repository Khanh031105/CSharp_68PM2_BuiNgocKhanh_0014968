using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const string VALID_USERNAME = "0014968@st.huce.edu.vn";
        private const string VALID_PASSWORD = "0014968";

        public Form1()
        {
            InitializeComponent();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            txt_password.PasswordChar = '*';
            this.AcceptButton = btnlogin;
        }

        private bool IsValidCredentials(string username, string password)
        {
            return username == VALID_USERNAME && password == VALID_PASSWORD;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui Lòng Nhập Tên Đăng Nhập Và Password.",
                                "Thong bao",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (IsValidCredentials(username, password))
            {
                MessageBox.Show("Đăng Nhập Thành Công!",
                                "Thanh cong",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ten dang nhap hoac mat khau khong dung.",
                                "That bai",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txt_password.Clear();
                txt_password.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
