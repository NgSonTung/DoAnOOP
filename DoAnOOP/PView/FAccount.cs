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
            LoadDSAccount();
            dgvAccount.Columns[0].Visible = false;
            /*LoadCBAcc();*/
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
            int vitri = dgvAccount.CurrentCell.RowIndex;
            int lastcell = int.Parse(dgvAccount.Rows[vitri].Cells["Auth"].Value + "");
            cbmAuth.Text = lastcell == 0 ? "Giáo Viên" : "Quản Trị Viên"; 
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvAccount_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvAccount.CurrentCell.RowIndex;
            string ma = dgvAccount.Rows[index].Cells[0].Value + "";

            if (ControlAccount.DefineAcc(ma) != null)
            {
                LoadAcc(ControlAccount.DefineAcc(ma));
            }
        }

        private void themAccBTN_Click_1(object sender, EventArgs e)
        {
            if(ControlAccount.db.Accounts.FirstOrDefault(x => x.UserName == userNameTXT.Text) == null)
            {
                if (userNameTXT.Text != "" && PassTXT.Text != null && cbmAuth.Text != null)
                {
                    Account acc = new Account { UserName = userNameTXT.Text, Password = PassTXT.Text, Auth = cbmAuth.SelectedIndex == 0 ? 1 : 0 };
                    ControlAccount.Add(acc);
                    LoadDSAccount();
                    IdAccTXT.Clear();
                    userNameTXT.Clear();
                    PassTXT.Clear();
                }
                else
                    MessageBox.Show("Hãy nhập lại thông tin");
            }
            else
                MessageBox.Show("Tên người dùng đã được sử dụng");
        }

        private void xoaAccBTN_Click(object sender, EventArgs e)
        {
            int index = dgvAccount.CurrentCell.RowIndex;
            string maacc = dgvAccount.Rows[index].Cells[0].Value + "";

            ControlAccount.Delete(ControlAccount.DefineAcc(maacc));
            LoadDSAccount();
        }

        private void capNhatAcc_Click(object sender, EventArgs e)
        {
            int index = dgvAccount.CurrentCell.RowIndex;
            string idacc = dgvAccount.Rows[index].Cells[0].Value + "";
            Account acc = ControlAccount.DefineAcc(idacc);
            acc.UserName = userNameTXT.Text;
            acc.Password = PassTXT.Text;
            if (cbmAuth.Text == "Giáo Viên")
                acc.Auth = 0;
            else
                acc.Auth = 1;
            ControlAccount.Update(acc);
            LoadDSAccount();
        }

        private void xemAccBTN_Click(object sender, EventArgs e)
        {
            LoadDSAccount();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin f = new FAdmin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f = new FLogin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void manageAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FManage f = new FManage();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timKiemAccBTN_Click(object sender, EventArgs e)
        {
            LoadDSAccount(ControlAccount.AccountSearching(timkiemAccTXT.Text));
        }

        private void themAccBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Thêm Account";
        }

        private void themAccBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xoaAccBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Xóa Account";
        }

        private void xoaAccBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void capNhatAcc_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Cập nhật Account";
        }

        private void capNhatAcc_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void timKiemAccBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Tìm kiếm Account";
        }

        private void timKiemAccBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xemAccBTN_MouseHover(object sender, EventArgs e)
        {

        }

        private void cbmAuth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadCBAcc()
        {
            List<Account> dsacc = ControlAccount.FindAll();
            cbmAuth.DataSource = dsacc;
            cbmAuth.DisplayMember = "Auth";
        }
    }
}
