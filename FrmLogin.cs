using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="nguyen"&& textBox2.Text == "123")
            {
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("sai tên đăng nhặp hoặc mặt khẩu","lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
