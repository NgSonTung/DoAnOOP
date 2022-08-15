using DoAnOOP.PControl;
using DoAnOOP.PView;
using System;
using System.Collections.Generic;
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
        
        public FAdmin()
        {
            InitializeComponent();
            //loadAutocomplete();
            loadCbMaLop();
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
            
            return hvs.ToList();
        }
        void loadFindHvByMaLop(string s)
        {
            var lst = ctrClass.findLopByMaLop(s);
            List<HocVien> hvs = new List<HocVien>();
            foreach (var l in lst)
            {
                hvs.AddRange(l.HocViens.ToList());
            }
            dataGridView1.DataSource = hvs.ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loadFindKG();
        }

        private void LapDsHvCuaMotLop_Click(object sender, EventArgs e)
        {

            loadFindHvByMaLop(maLopcb.SelectedItem.ToString());
        }
        void loadCbMaLop()
        {
            var rs = from t in ctrClass.FindLop() select t.MaLop;
            maLopcb.DataSource = rs.ToList();
            maLopcb.DisplayMember = "MaLop";
            tenLopTXT.ReadOnly = true;
            hocPhiTXT.ReadOnly = true;
            hocPhanTXT.ReadOnly = true;
            Montxt.ReadOnly = true;
            var rst = from s in ctrHV.FindAll() select s.MaHocVien;
            cbmahv.DataSource = rs.ToList();
            cbmahv.DisplayMember = "MaHocVien";
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
        void loadInforHV(string mahv)
        {
            HocVien hv = ctrHV.FindHV(mahv);
            hoTenTXT.Text = hv.HoTen;
            ngaySinhDP.Value = hv.NgaySinh;
            ngheNghiepTXT.Text = hv.NgheNghiep;
            noiSinhTXT.Text = hv.NoiSinh;

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
            dataGridView1.DataSource = rs.ToList();
        }
        void loadAutocomplete()
        {
            doAnEntities db = new doAnEntities();
            var rs = db.HocViens.Select(t => t.HoTen).Distinct().ToArray();
            
            AutoCompleteStringCollection lst = new AutoCompleteStringCollection();
            lst.AddRange(rs);

            hoTenTXT.AutoCompleteCustomSource = lst;
            dataGridView1.DataSource = lst;
            //maHvTXT.AutoCompleteCustomSource = lst;
        }
        private void huyDangKyBTN_Click(object sender, EventArgs e)
        {
            ctrTG.RemoveLopTheoHV(cbmahv.Text, maLopcb.Text);
            loadCbMaLop();
        }

        private void dangKyBTN_Click(object sender, EventArgs e)
        {
            //add ? => fill infor 2 cbx
           
            if (checkHsToLop(int.Parse(cbmahv.SelectedItem.ToString())) == false)
            {
                MessageBox.Show("Học viên đã tham gia lớp này !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đăng kí thành công !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrTG.addHsToLop(cbmahv.SelectedItem.ToString(), maLopcb.SelectedItem.ToString());
            }

        }
        bool checkHsToLop(int mahv)
        {
          List<HocVien> lst = loadFindKG().Where(t => t.MaHocVien == mahv).ToList();
            if (lst.Count > 1) return false;
            else return true;
        }
        private void maLopcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInforLop();
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

        private void cbmahv_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadInforHV(cbmahv.SelectedItem.ToString());
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
    }
}
