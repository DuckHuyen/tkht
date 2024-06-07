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
    public partial class dkcvdi : Form
    {
        public dkcvdi()
        {
            InitializeComponent();
        }

        private void dkcvdi_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox(comboBox1, "coquan", "tencoquan");
            LoadDataIntoComboBox(comboBox2, "donvi", "tendonvi");

        }
        private void LoadDataIntoComboBox( ComboBox yourComboBox, string table, string column)
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

        public void InsertDataIntoCongVanDi()
        {
            string connectionString = "Host=localhost;Database=x;Username=postgres;Password=Duckhuyen1.;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO CongVanDi (MaCV, KHCV, NgayGui, CQGui, DVNhan, Ma_LoaiCV, Ma_LV, TieuDe, TrichYeu, NgayPD, NguoiPD, URLFile) " +
                               "VALUES (@MaCV, @KHCV, @NgayGui, @CQGui, @DVNhan, @Ma_LoaiCV, @Ma_LV, @TieuDe, @TrichYeu, @NgayPD, @NguoiPD, @URLFile)";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaCV", TextBox1.Text);
                    command.Parameters.AddWithValue("@KHCV", TextBox2.Text);
                    command.Parameters.AddWithValue("@NgayGui",TextBox3.Text); // Assuming you handle date parsing correctly
                    command.Parameters.AddWithValue("@CQGui", comboBox1.Text);
                    command.Parameters.AddWithValue("@DVNhan", comboBox2.Text);
                    command.Parameters.AddWithValue("@Ma_LoaiCV", TextBox11.Text);
                    command.Parameters.AddWithValue("@Ma_LV", TextBox12.Text);
                    command.Parameters.AddWithValue("@TieuDe", TextBox6.Text);
                    command.Parameters.AddWithValue("@TrichYeu", RichTextBox1.Text);
                    command.Parameters.AddWithValue("@NgayPD", TextBox9.Text); // Assuming you handle date parsing correctly
                    command.Parameters.AddWithValue("@NguoiPD", TextBox8.Text);
                    command.Parameters.AddWithValue("@URLFile", TextBox10.Text);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InsertDataIntoCongVanDi();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
