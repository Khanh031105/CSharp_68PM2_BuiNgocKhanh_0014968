using Microsoft.Data.SqlClient;
using System.Data;

namespace QLSV
{
    public partial class QLSinhVien : UserControl
    {
        int currentPage = 1;
        int pageSize = 4;
        int totalRows = 0;

        public QLSinhVien()
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

                string countQuery = "SELECT COUNT(*) FROM SinhVien";
                SqlCommand countCmd = new SqlCommand(countQuery, conn);
                totalRows = (int)countCmd.ExecuteScalar();

                int skip = (currentPage - 1) * pageSize;

                string query = @"SELECT * FROM SinhVien
                                 ORDER BY MaSV
                                 OFFSET @Skip ROWS
                                 FETCH NEXT @PageSize ROWS ONLY";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Skip", skip);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);

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

            int totalPage = (int)Math.Ceiling((double)totalRows / pageSize);
            if (totalPage == 0) totalPage = 1;

            label7.Text = "Trang " + currentPage + "/" + totalPage + " | " + totalRows + " bản ghi";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();

                string check = "SELECT COUNT(*) FROM SinhVien WHERE MaSV=@MaSV";
                SqlCommand checkCmd = new SqlCommand(check, conn);
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
            using (SqlConnection conn = new Database().GetConnection())
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

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                    MessageBox.Show("Sửa thành công!");
                else
                    MessageBox.Show("Không tìm thấy sinh viên!");
            }

            LoadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            using (SqlConnection conn = new Database().GetConnection())
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
            currentPage = 1;
            dataGridView1.Rows.Clear();

            using (SqlConnection conn = new Database().GetConnection())
            {
                conn.Open();

                string query = @"SELECT * FROM SinhVien
                                WHERE MaSV LIKE @key
                                OR HoTen LIKE @key
                                OR MaLop LIKE @key";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@key", "%" + textBox3.Text.Trim() + "%");

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

            comboBox1.SelectedIndex = 0;
            comboBox2.Text = "68PM1 – Lớp 68PM1";

            currentPage = 1;
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            comboBox1.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);

            comboBox2.Text =
                row.Cells[4].Value.ToString() +
                " – Lớp " +
                row.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int totalPage = (int)Math.Ceiling((double)totalRows / pageSize);

            if (currentPage < totalPage)
            {
                currentPage++;
                LoadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int totalPage = (int)Math.Ceiling((double)totalRows / pageSize);
            if (totalPage == 0) totalPage = 1;

            currentPage = totalPage;
            LoadData();
        }
    }
}