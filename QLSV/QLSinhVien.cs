using Microsoft.Data.SqlClient;

namespace QLSV
{
    public partial class QLSinhVien : UserControl
    {
        public QLSinhVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM SinhVien";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["MaSV"].ToString(),
                        reader["HoTen"].ToString(),
                        reader["GioiTinh"].ToString(),
                        Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"),
                        reader["MaLop"].ToString()
                    );
                }
            }

            label7.Text = "Trang 1/1 | " + dataGridView1.Rows.Count + " bản ghi";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM SinhVien WHERE MaSV=@MaSV";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaSV", textBox1.Text.Trim());

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }

                string query = @"INSERT INTO SinhVien
                (MaSV, HoTen, GioiTinh, NgaySinh, MaLop)
                VALUES
                (@MaSV, @HoTen, @GioiTinh, @NgaySinh, @MaLop)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaSV", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@HoTen", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox1.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@MaLop", comboBox2.Text.Split(' ')[0]);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm thành công!");
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE SinhVien
                SET HoTen=@HoTen,
                    GioiTinh=@GioiTinh,
                    NgaySinh=@NgaySinh,
                    MaLop=@MaLop
                WHERE MaSV=@MaSV";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaSV", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@HoTen", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", comboBox1.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@MaLop", comboBox2.Text.Split(' ')[0]);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Sửa thành công!");
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Chọn sinh viên cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No)
                return;

            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM SinhVien WHERE MaSV=@MaSV";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@MaSV", textBox1.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Xóa thành công!");
            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string key = textBox3.Text.Trim();

            dataGridView1.Rows.Clear();

            Database db = new Database();

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT * FROM SinhVien
                WHERE MaSV LIKE @key
                OR HoTen LIKE @key
                OR MaLop LIKE @key";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@key", "%" + key + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["MaSV"].ToString(),
                        reader["HoTen"].ToString(),
                        reader["GioiTinh"].ToString(),
                        Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"),
                        reader["MaLop"].ToString()
                    );
                }
            }

            label7.Text = "Trang 1/1 | " + dataGridView1.Rows.Count + " bản ghi";
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.Text = "Nam";
            comboBox2.Text = "68PM1 – Lớp 68PM1";

            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            comboBox1.Text = row.Cells[2].Value.ToString();

            dateTimePicker1.Value =
                Convert.ToDateTime(row.Cells[3].Value);

            comboBox2.Text =
                row.Cells[4].Value.ToString() +
                " – Lớp " +
                row.Cells[4].Value.ToString();
        }
    }
}