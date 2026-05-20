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
            dataGridView1.Rows.Add("1", "68PM1", "Lớp 68PM1", "Công nghệ thông tin");
            dataGridView1.Rows.Add("2", "68PM2", "Lớp 68PM2", "Công nghệ thông tin");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            var r = dataGridView1.CurrentRow;
            r.Cells[0].Value = textBox1.Text;
            r.Cells[1].Value = textBox2.Text;
            r.Cells[2].Value = textBox3.Text;
            r.Cells[3].Value = textBox4.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(r.Cells[0].Value);
            textBox2.Text = Convert.ToString(r.Cells[1].Value);
            textBox3.Text = Convert.ToString(r.Cells[2].Value);
            textBox4.Text = Convert.ToString(r.Cells[3].Value);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string key = textBoxSearch.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool show = string.IsNullOrEmpty(key);
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (Convert.ToString(row.Cells[i].Value).ToLower().Contains(key))
                    {
                        show = true;
                        break;
                    }
                }
                row.Visible = show;
            }
        }
    }
}
