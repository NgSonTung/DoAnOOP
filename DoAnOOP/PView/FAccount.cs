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
    public partial class FAccount : Form
    {
        public FAccount()
        {
            InitializeComponent();
        }


        private void FAccount_Load(object sender, EventArgs e)
        {

        }

        void LoadDSAccount()
        {
            var acc = from s in ControlAccount.FindAll() select new { s.MaTaiKhoan, s.UserName, s.Password, s.Auth };
            dgvAccount.DataSource = acc.ToList();
        }

        void LoadDSAccount(List<Account> acc)
        {
            var list = from s in acc select new { s.MaTaiKhoan, s.UserName, s.Password, s.Auth };
            dgvAccount.DataSource = list.ToList();
        }

        void LoadAcc(Account Acc)
        {
            IdAccTXT.Text = Acc.MaTaiKhoan.ToString();
            userNameTXT.Text = Acc.UserName;
            PassTXT.Text = Acc.Password;
            AuthTXT.Text = Acc.Auth.ToString();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvAccount.CurrentCell.RowIndex;
            string ma = dgvAccount.Rows[index].Cells[0].Value + "";

            if (ControlAccount.DefineAcc(ma) != null)
            {
                LoadAcc(ControlAccount.DefineAcc(ma));
            }
        }

        private void themAccBTN_Click(object sender, EventArgs e)
        {
            if (IdAccTXT.Text != "" && userNameTXT.Text != "" && PassTXT.Text != null && AuthTXT.Text != null)
            {
                Account acc = new Account { MaTaiKhoan = int.Parse(IdAccTXT.Text), UserName = userNameTXT.Text, Password = PassTXT.Text, Auth = int.Parse(PassTXT.Text) };
                ControlAccount.Add(acc);
                LoadDSAccount();
                IdAccTXT.Clear();
                userNameTXT.Clear();
                PassTXT.Clear();
                AuthTXT.Clear();
            }
            else
                MessageBox.Show("Hãy nhập lại thông tin");
        }
    }
}
