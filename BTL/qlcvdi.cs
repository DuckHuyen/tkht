using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace BTL
{
    public partial class qlcvdi : Form
    {
        public qlcvdi()
        {
            InitializeComponent();
        }

        private void qlcvdi_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox(comboBox3, "coquan", "tencoquan");
            LoadDataIntoComboBox(comboBox1, "loaicv", "tenloaicv");
            LoadDataIntoComboBox(comboBox2, "linhvuc", "tenlinhvuc");
            listView1.Items.Clear();
            DataTable dataTable = GetDataFromDatabase();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                item.SubItems.Add(row[6].ToString());
                item.SubItems.Add(row[7].ToString());
                item.SubItems.Add(row[8].ToString());
                item.SubItems.Add(row[9].ToString());
                item.SubItems.Add(row[10].ToString());
                item.SubItems.Add(row[11].ToString());
                listView1.Items.Add(item);
            }
        }
        private DataTable GetDataFromDatabase()
        {
            string connectionString = "Host=localhost;Database=x;Username=postgres;Password=Duckhuyen1.;";
            string query = "SELECT * FROM congvandi";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        private void LoadDataIntoComboBox(ComboBox yourComboBox, string table, string column)
        {
            string connectionString = "Host=localhost;Database=x;Username=postgres;Password=Duckhuyen1.;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT " + column + " FROM " + table;
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        yourComboBox.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                yourComboBox.Items.Add(reader[column].ToString());
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xử lý trường hợp để trống
            if (TextBox1.Text.Trim() == "" && TextBox2.Text.Trim() == "" && comboBox1.Text.Trim() == "" && comboBox2.Text.Trim() == "" && comboBox3.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin khi tìm kiếm");
                return;
            }
            //tìm kiếm các đơn vị theo thông tin của người dùng và tải lên listview
            string connectionString = "Host=localhost;Database=x;Username=postgres;Password=Duckhuyen1.;";
            string query = "SELECT * FROM congvandi WHERE 1 = 1";
            if (TextBox1.Text.Trim() != "") query += " AND macv = @macv";
            if (TextBox2.Text.Trim() != "") query += " AND khcv = @khcv";
            if (comboBox1.Text.Trim() != "") query += " AND ma_loaicv = (SELECT maloaicv FROM loaicv WHERE tenloaicv = @tenloaicv)";
            if (comboBox2.Text.Trim() != "") query += " AND ma_lv = (SELECT malinhvuc FROM linhvuc WHERE tenlinhvuc = @tenlinhvuc)";
            if (comboBox3.Text.Trim() != "") query += " AND cqgui LIKE @cqgui";
            DataTable dataTable = new DataTable();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                if (TextBox1.Text.Trim() != "") command.Parameters.AddWithValue("@macv", TextBox1.Text.Trim());
                if (TextBox2.Text.Trim() != "") command.Parameters.AddWithValue("@khcv", TextBox2.Text.Trim());
                if (comboBox1.Text.Trim() != "") command.Parameters.AddWithValue("@tenloaicv", comboBox1.Text.Trim());
                if (comboBox2.Text.Trim() != "") command.Parameters.AddWithValue("@tenlinhvuc", comboBox2.Text.Trim());
                if (comboBox3.Text.Trim() != "") command.Parameters.AddWithValue("@cqgui", comboBox3.Text.Trim());
                listView1.Items.Clear();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

            }
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                item.SubItems.Add(row[1].ToString());
                item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[3].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[5].ToString());
                item.SubItems.Add(row[6].ToString());
                item.SubItems.Add(row[7].ToString());
                item.SubItems.Add(row[8].ToString());
                item.SubItems.Add(row[9].ToString());
                item.SubItems.Add(row[10].ToString());
                item.SubItems.Add(row[11].ToString());
                listView1.Items.Add(item);
            }
        }


    }
}
