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
    public partial class DangNhap : Form
    {
        bool checkPass = false;
        private const string Host = "localhost";
        private const string Database = "x";
        private const string Username = "postgres";
        private const string Pass = "Duckhuyen1.";

        public DangNhap()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tên tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                if (checkPass == false) txtMatKhau.PasswordChar = '*';
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "")
            {
                txtTaiKhoan.Text = "Nhập tên tài khoản";
                txtTaiKhoan.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim() == "")
            {
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkPass == true)
            {
                checkPass = false;
                txtMatKhau.PasswordChar = '*';
                if (txtMatKhau.Text == "Nhập mật khẩu") txtMatKhau.PasswordChar = '\0';
                picbNhinMatKhau.BackColor = Color.White;
            }
            else
            {
                checkPass = true;
                txtMatKhau.PasswordChar = '\0';
                picbNhinMatKhau.BackColor = SystemColors.ControlLight;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim().Contains(" ") || txtMatKhau.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu đúng định dạng");
                return;
            }

            string connectionString = "Host=localhost;Database=x;Username=postgres;Password=Duckhuyen1.;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM humger WHERE Username = @Username AND Password = @Password";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", txtTaiKhoan.Text.Trim());
                    command.Parameters.AddWithValue("@Password", txtMatKhau.Text.Trim());       
   
                        connection.Open();
                        object result = command.ExecuteScalar();
                        int count;
                        if (result != null && int.TryParse(result.ToString(), out count))
                        {
                            if (count <= 0)
                            {
                                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                            }
                            else
                            {
                                Main f = new Main();
                                this.Hide();
                                f.ShowDialog();
                                this.Close();
                            }
                        }
                     
                    }
                 
                }
            }

        private void DangNhap_Load(object sender, EventArgs e)
        {
           
        }
        }
    
}
