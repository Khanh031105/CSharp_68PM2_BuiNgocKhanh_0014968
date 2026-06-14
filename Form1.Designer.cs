namespace QLSV
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btnlogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btnlogin = new Button();
            SuspendLayout();

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 64, 89);
            label1.Location = new Point(230, 70);
            label1.Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";

            label2.AutoSize = true;
            label2.Location = new Point(235, 160);
            label2.Text = "Tên đăng nhập:";

            txt_username.Location = new Point(360, 156);
            txt_username.Size = new Size(260, 27);

            label3.AutoSize = true;
            label3.Location = new Point(235, 210);
            label3.Text = "Mật khẩu:";

            txt_password.Location = new Point(360, 206);
            txt_password.Size = new Size(260, 27);

            btnlogin.BackColor = Color.FromArgb(55, 76, 100);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(405, 265);
            btnlogin.Size = new Size(150, 45);
            btnlogin.Text = "Đăng nhập";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(850, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(btnlogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
