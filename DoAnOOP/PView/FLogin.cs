using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnOOP.PControl;

namespace DoAnOOP.PView
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
            ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ControlAccount.Login(textBox1.Text, textBox2.Text))
            {
                ControlAccount.Account = ControlAccount.db.Accounts.FirstOrDefault(x => x.UserName == textBox1.Text && x.Password == textBox2.Text);
                this.Hide();
                FAdmin f = new FAdmin();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
