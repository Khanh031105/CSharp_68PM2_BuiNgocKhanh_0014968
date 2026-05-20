namespace QLSV
{
    partial class QLLopHoc
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBoxSearch;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_refesh;
        private Button btn_search;
        private Label label6;
        private DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBoxSearch = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_refesh = new Button();
            btn_search = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            BackColor = Color.FromArgb(240, 240, 240);

            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(15, 35);
            groupBox1.Size = new Size(470, 470);
            groupBox1.Text = "Thông tin lớp học";

            label1.Location = new Point(18, 45);
            label1.Text = "Mã ID:";
            textBox1.Location = new Point(18, 75);
            textBox1.Size = new Size(430, 27);

            label2.Location = new Point(18, 135);
            label2.Text = "Mã lớp:";
            textBox2.Location = new Point(18, 165);
            textBox2.Size = new Size(430, 27);

            label3.Location = new Point(18, 225);
            label3.Text = "Tên lớp:";
            textBox3.Location = new Point(18, 255);
            textBox3.Size = new Size(430, 27);

            label4.Location = new Point(18, 315);
            label4.Text = "Ghi chú:";
            textBox4.Location = new Point(18, 345);
            textBox4.Size = new Size(430, 27);

            btn_add.BackColor = Color.FromArgb(52, 152, 219);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_add.Location = new Point(15, 530);
            btn_add.Size = new Size(225, 58);
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;

            btn_update.BackColor = Color.FromArgb(39, 174, 96);
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.White;
            btn_update.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_update.Location = new Point(260, 530);
            btn_update.Size = new Size(225, 58);
            btn_update.Text = "Sửa";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;

            btn_delete.BackColor = Color.FromArgb(231, 76, 60);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_delete.Location = new Point(15, 610);
            btn_delete.Size = new Size(225, 58);
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;

            btn_refesh.BackColor = Color.FromArgb(127, 140, 141);
            btn_refesh.FlatStyle = FlatStyle.Flat;
            btn_refesh.ForeColor = Color.White;
            btn_refesh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_refesh.Location = new Point(260, 610);
            btn_refesh.Size = new Size(225, 58);
            btn_refesh.Text = "Làm mới";
            btn_refesh.UseVisualStyleBackColor = false;
            btn_refesh.Click += btn_refesh_Click;

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(510, 35);
            label6.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";

            textBoxSearch.Location = new Point(510, 65);
            textBoxSearch.Size = new Size(400, 27);

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
            dataGridView1.Columns.Add("MaID", "Mã ID");
            dataGridView1.Columns.Add("MaLop", "Mã lớp");
            dataGridView1.Columns.Add("TenLop", "Tên lớp");
            dataGridView1.Columns.Add("GhiChu", "Ghi chú");

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_refesh);
            Controls.Add(label6);
            Controls.Add(textBoxSearch);
            Controls.Add(btn_search);
            Controls.Add(dataGridView1);
            Name = "QLLopHoc";
            Size = new Size(1500, 850);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
