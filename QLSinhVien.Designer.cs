namespace QLSV
{
    partial class QLSinhVien
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBox1;
        private Label txt_mssv;
        private Label txt_name;
        private Label txt_date;
        private Label txt_gender;
        private Label txt_class;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_refesh;
        private Button btn_search;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txt_mssv = new Label();
            txt_name = new Label();
            txt_date = new Label();
            txt_gender = new Label();
            txt_class = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_refesh = new Button();
            btn_search = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            BackColor = Color.FromArgb(240, 240, 240);

            groupBox1.Controls.Add(txt_mssv);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(txt_date);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txt_gender);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txt_class);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(15, 35);
            groupBox1.Size = new Size(470, 570);
            groupBox1.Text = "Thông tin sinh viên";

            txt_mssv.Location = new Point(18, 40);
            txt_mssv.Size = new Size(150, 25);
            txt_mssv.Text = "Mã sinh viên:";
            textBox1.Location = new Point(18, 70);
            textBox1.Size = new Size(430, 27);

            txt_name.Location = new Point(18, 135);
            txt_name.Size = new Size(150, 25);
            txt_name.Text = "Họ và tên:";
            textBox2.Location = new Point(18, 165);
            textBox2.Size = new Size(430, 27);

            txt_date.Location = new Point(18, 230);
            txt_date.Size = new Size(150, 25);
            txt_date.Text = "Ngày sinh:";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(18, 260);
            dateTimePicker1.Size = new Size(430, 27);

            txt_gender.Location = new Point(18, 325);
            txt_gender.Size = new Size(150, 25);
            txt_gender.Text = "Giới tính:";
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            comboBox1.Location = new Point(18, 355);
            comboBox1.Size = new Size(430, 28);
            comboBox1.Text = "Nam";

            txt_class.Location = new Point(18, 420);
            txt_class.Size = new Size(150, 25);
            txt_class.Text = "Lớp:";
            comboBox2.Items.AddRange(new object[] { "68PM1 – Lớp 68PM1", "68PM2 – Lớp 68PM2" });
            comboBox2.Location = new Point(18, 450);
            comboBox2.Size = new Size(430, 28);
            comboBox2.Text = "68PM1 – Lớp 68PM1";

            btn_add.BackColor = Color.FromArgb(52, 152, 219);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_add.Location = new Point(15, 625);
            btn_add.Size = new Size(225, 58);
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;

            btn_update.BackColor = Color.FromArgb(39, 174, 96);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.White;
            btn_update.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_update.Location = new Point(260, 625);
            btn_update.Size = new Size(225, 58);
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;

            btn_delete.BackColor = Color.FromArgb(231, 76, 60);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_delete.Location = new Point(15, 705);
            btn_delete.Size = new Size(225, 58);
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;

            btn_refesh.BackColor = Color.FromArgb(127, 140, 141);
            btn_refesh.FlatStyle = FlatStyle.Flat;
            btn_refesh.ForeColor = Color.White;
            btn_refesh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_refesh.Location = new Point(260, 705);
            btn_refesh.Size = new Size(225, 58);
            btn_refesh.Text = "Làm mới";
            btn_refesh.UseVisualStyleBackColor = false;
            btn_refesh.Click += btn_refesh_Click;

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(510, 35);
            label6.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";

            textBox3.Location = new Point(510, 65);
            textBox3.Size = new Size(400, 27);

            btn_search.BackColor = Color.FromArgb(55, 76, 100);
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.ForeColor = Color.White;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_search.Location = new Point(930, 62);
            btn_search.Size = new Size(135, 50);
            btn_search.Text = "Tìm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(510, 130);
            dataGridView1.Size = new Size(930, 560);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.Columns.Add("MaSV", "Mã SV");
            dataGridView1.Columns.Add("HoTen", "Họ và Tên");
            dataGridView1.Columns.Add("GioiTinh", "Giới Tính");
            dataGridView1.Columns.Add("NgaySinh", "Ngày Sinh");
            dataGridView1.Columns.Add("Lop", "Lớp");

            button1.Location = new Point(510, 710);
            button1.Size = new Size(75, 60);
            button1.Text = "<<";
            button1.Click += button1_Click;

            button2.Location = new Point(585, 710);
            button2.Size = new Size(75, 60);
            button2.Text = "<";
            button2.Click += button2_Click;

            button3.Location = new Point(1050, 710);
            button3.Size = new Size(75, 60);
            button3.Text = ">";
            button3.Click += button3_Click;

            button4.Location = new Point(1125, 710);
            button4.Size = new Size(75, 60);
            button4.Text = ">>";
            button4.Click += button4_Click;

            label7.AutoSize = true;
            label7.Location = new Point(790, 730);
            label7.Text = "Trang 1/1   |   3 bản ghi";

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_refesh);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(btn_search);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label7);
            Name = "QLSinhVien";
            Size = new Size(1500, 850);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
