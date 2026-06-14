using Microsoft.Data.SqlClient;

namespace QLSV
{
    public partial class QLLopHoc : UserControl
    {
        public QLLopHoc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();

                string query = "SELECT Id, MaLop, TenLop, GhiChu FROM LopHoc";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["Id"].ToString(),
                        reader["MaLop"].ToString(),
                        reader["TenLop"].ToString(),
                        reader["GhiChu"].ToString()
                    );
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO LopHoc (MaLop, TenLop, GhiChu)
                                 VALUES (@MaLop, @TenLop, @GhiChu)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLop", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@TenLop", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@GhiChu", textBox4.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm lớp học thành công!");
            LoadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();

                string query = @"UPDATE LopHoc
                                 SET MaLop=@MaLop, TenLop=@TenLop, GhiChu=@GhiChu
                                 WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@MaLop", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@TenLop", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@GhiChu", textBox4.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Sửa lớp học thành công!");
            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();

                string query = "DELETE FROM LopHoc WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", textBox1.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Xóa lớp học thành công!");
            LoadData();
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBoxSearch.Clear();

            LoadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();

                string query = @"SELECT Id, MaLop, TenLop, GhiChu
                                 FROM LopHoc
                                 WHERE MaLop LIKE @key
                                 OR TenLop LIKE @key
                                 OR GhiChu LIKE @key";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@key", "%" + textBoxSearch.Text.Trim() + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["Id"].ToString(),
                        reader["MaLop"].ToString(),
                        reader["TenLop"].ToString(),
                        reader["GhiChu"].ToString()
                    );
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void btn_viewSinhVien_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn lớp học!");
                return;
            }

            string maLop = textBox2.Text.Trim();
            string danhSach = "";

            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();

                string query = @"SELECT MaSV, HoTen, GioiTinh, NgaySinh
                                 FROM SinhVien
                                 WHERE MaLop=@MaLop";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    danhSach +=
                        "Mã SV: " + reader["MaSV"] +
                        " | Họ tên: " + reader["HoTen"] +
                        " | Giới tính: " + reader["GioiTinh"] +
                        " | Ngày sinh: " + Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy") +
                        "\n";
                }
            }

            if (danhSach == "")
                MessageBox.Show("Lớp này chưa có sinh viên!");
            else
                MessageBox.Show(danhSach, "Danh sách sinh viên lớp " + maLop);
        }
    }
}