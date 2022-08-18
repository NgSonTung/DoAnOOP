using DoAnOOP.PControl;
using DoAnOOP.PView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace DoAnOOP
{
    public partial class FAdmin : Form
    {
        ControlClass ctrClass = new ControlClass();
        ControlHocVien ctrHV = new ControlHocVien();
        ControlThamGia ctrTG = new ControlThamGia();
        ControlBienLai ctrBL = new ControlBienLai();
        public FAdmin()
        {
            InitializeComponent();
            loadAutocomplete();
            loadCbMaLop();
            CheckAuth();
            loadDgvADFirst();
            
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FManage f = new FManage();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }

        List<HocVien> loadFindKG()
        {
            var lst = ctrClass.findLopKG(khaiGiangDP.Value);
            List<HocVien> hvs = new List<HocVien>();
            foreach (var l in lst)
            {
                hvs.AddRange(l.HocViens.ToList());
                //addrange add can list 
            }
            return hvs;
        }
        void loadFindHvByMaLop(string s)
        {
            var lst = ctrClass.findLopByMaLop(s);
            List<HocVien> hvs = new List<HocVien>();
            foreach (var l in lst)
            {
                hvs.AddRange(l.HocViens.ToList());
            }
            var rs = from t in loadFindKG() select new { t.HoTen,t.NgaySinh,t.NoiSinh,t.NgheNghiep };
            dgvAD.DataSource = rs.ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            paneltongsl.Visible = false;
            var rs = from t in loadFindKG() select new { t.HoTen,t.NgaySinh,t.NoiSinh,t.NgheNghiep };
            dgvAD.DataSource = rs.ToList();
        }

        private void LapDsHvCuaMotLop_Click(object sender, EventArgs e)
        {
            paneltongsl.Visible = false;
            loadFindHvByMaLop(maLopcb.SelectedItem.ToString());
        }
        void loadCbMaLop()
        {
            var rs = from t in ctrClass.FindLop() select t.MaLop;
            maLopcb.DataSource = rs.ToList();
            maLopcb.DisplayMember = "MaLop";
            maLopcb.DropDownStyle = ComboBoxStyle.DropDownList;
            Montxt.ReadOnly = true;
            
        }
        void loadInforLop()
        {
            Lop l = ctrClass.findInfoLop(int.Parse(maLopcb.SelectedItem.ToString()));
            tenLopTXT.Text = l.TenLop;
            khaiGiangDP.Value = l.NgayKhaiGiang;
            hocPhiTXT.Text = l.HocPhi.ToString();
            hocPhanTXT.Text = l.HocPhan.ToString();
            DateTime dt = DateTime.Today;
            TimeSpan ts = l.TKB;
            tkbDP.Value = dt + ts;
            Montxt.Text = l.MonHoc.TenMonHoc;
        }
        void loadInforHVbyMahv(string s)
        {
            HocVien hv = ctrHV.FindHV(s);
            hoTenTXT.Text = hv.HoTen;
            ngaySinhDP.Value = hv.NgaySinh;
            ngheNghiepTXT.Text = hv.NgheNghiep;
            noiSinhTXT.Text = hv.NoiSinh;
        }
        void loadInforHVbyName(string name)
        {
            List<HocVien> hv = ctrHV.FindHVByName(name);
            foreach (var i in hv)
            {
                cbmahv.Text = i.MaHocVien.ToString();
                ngaySinhDP.Value = i.NgaySinh;
                ngheNghiepTXT.Text = i.NgheNghiep;
                noiSinhTXT.Text = i.NoiSinh;
            }
            
        }
        void loadInforLopbyName(string n)
        {
            List<Lop> l = ctrClass.findLopByName(n);
            foreach (var i in l)
            {
                maLopcb.SelectedItem = i.MaLop;
                khaiGiangDP.Value = i.NgayKhaiGiang;
                hocPhiTXT.Text = i.HocPhi.ToString();
                hocPhanTXT.Text = i.HocPhan.ToString();
                DateTime dt = DateTime.Today;
                TimeSpan ts = i.TKB;
                tkbDP.Value = dt + ts;
                Montxt.Text = i.MonHoc.TenMonHoc;
            }
        }
        void loadDgvADFirst()
        {
            var rs = from t in ctrHV.FindAll() select new { t.HoTen, t.NgaySinh, t.NoiSinh, t.NgheNghiep };
            dgvAD.DataSource = rs.ToList();
        }
        void loadAutocomplete()
        {
            List<HocVien> hv = ctrHV.FindAll();
            AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
            string a = "";
            foreach (HocVien i in hv)
            {
                a = i.HoTen;
                lst.Add(a);
            }
            hoTenTXT.AutoCompleteCustomSource = lst;
            List<Lop> lop = ctrClass.FindLop();
            AutoCompleteStringCollection lstlop = new AutoCompleteStringCollection();
            string b = "";
            foreach (Lop j in lop)
            {
                b = j.TenLop;
                lstlop.Add(b);
            }
            tenLopTXT.AutoCompleteCustomSource = lstlop;
        }
        private void ChoBietSLHVKGKhoaNgayNaoDo_Click(object sender, EventArgs e)
        {
            var lst = ctrClass.findLopKG(khaiGiangDP.Value);
            var rs = from t in lst
                     select new
                     {
                         TenLop = t.TenLop,
                         NgayKhaiGiang = t.NgayKhaiGiang,
                         SoHocVien = t.HocViens.Count
                     };

            List<HocVien> hvs = new List<HocVien>();
            foreach (var l in lst)
            {
                hvs.AddRange(l.HocViens.ToList());
            }
            test1.Text = hvs.Count.ToString();
            dgvAD.DataSource = rs.ToList();
            paneltongsl.Visible = true;
        }
        
        private void huyDangKyBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn muốn thêm môn học?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                ctrTG.RemoveLopTheoHV(cbmahv.Text, maLopcb.Text);
                loadCbMaLop();
                paneltongsl.Visible = false;
            }
        }

        private void dangKyBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn muốn thêm môn học?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                paneltongsl.Visible = false;
                if (checkHsToLop(int.Parse(cbmahv.Text)) == false)
                {
                    MessageBox.Show("Học viên đã tham gia lớp này !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ctrTG.addHsToLop(cbmahv.Text, maLopcb.SelectedItem.ToString());
                    HocVien hv = ctrHV.FindHV(cbmahv.Text);
                    ctrBL.AddBLDK(hv, double.Parse(hocPhiTXT.Text), int.Parse(maLopcb.SelectedItem.ToString()));
                }
            }
        }
        bool checkHsToLop(int mahv)
        {
          List<HocVien> lst = loadFindKG().Where(t => t.MaHocVien == mahv).ToList();
            if (lst.Count > 1) return false;
            else return true;
        }

        private void maHvTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only number
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void hoTenTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only text
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAccount f = new FAccount();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f = new FLogin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        void CheckAuth()
        {
            if (ControlAccount.Account.Auth == 1) /* auth = 1 thi la admin*/
                toolStripMenuItem1.Enabled = true;
            else
                toolStripMenuItem1.Enabled = false;
        }
        private void hoTenTXT_Leave(object sender, EventArgs e)
        {
                loadInforHVbyName(hoTenTXT.Text);
        }
        private void cbmahv_Leave(object sender, EventArgs e)
        {
                loadInforHVbyMahv(cbmahv.Text);
        }
        private void tenLopTXT_Leave(object sender, EventArgs e)
        {
            loadInforLopbyName(tenLopTXT.Text);
        }
        private void maLopcb_Leave(object sender, EventArgs e)
        {
            loadInforLop();
        }
        private void hoTenTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadInforHVbyName(hoTenTXT.Text);
            }
        }

        private void tenLopTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadInforLopbyName(tenLopTXT.Text);
            }
        }
    }
}
