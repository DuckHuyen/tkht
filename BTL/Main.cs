using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Main : Form
    {
        //id dùng để lưu lại id người dùng
        public int Id;
        public Main()
        {
            InitializeComponent();
        }
        //phương thức để xóa form cũ và thêm form mới vào panel chính
        private void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form); 
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void côngVănĐiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dkcvdi f = new dkcvdi();
            f.Show();
        }

        private void côngVănĐếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dkcvden f = new dkcvden();
            f.Show();
        }

        private void côngVănĐiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            qlcvdi f = new qlcvdi();
            AddFormToPanel(f);
        }

        private void côngVănĐếnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            qlcvden f = new qlcvden();
            AddFormToPanel(f);
        }

      
    }
}
