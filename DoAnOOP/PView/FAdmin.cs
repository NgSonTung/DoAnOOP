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
            //loadCbMaLop();
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
                if(rs.ToList().Count < 1)
            {
                MessageBox.Show("Danh sách rỗng !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            paneltongsl.Visible = false;
            var rs = from t in loadFindKG() select new { t.HoTen,t.NgaySinh,t.NoiSinh,t.NgheNghiep };
            dgvAD.DataSource = rs.ToList();
            if (rs.ToList().Count <1)
            {
                MessageBox.Show("Danh sách rỗng !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LapDsHvCuaMotLop_Click(object sender, EventArgs e)
        {
            paneltongsl.Visible = false;
            if(maLopcb.Text.Length <=0)
                MessageBox.Show("Oops! Đã xảy ra lỗi !! Bạn có chắc chắn rằng mọi dữ liệu bạn nhập đều đã chính xác ?!!!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                loadFindHvByMaLop(maLopcb.Text);
        }
        void loadInforLop()
        {
            List<Lop> i = ctrClass.findLopByMaLop(maLopcb.Text);
            foreach (var l in i)
            {
                tenLopTXT.Text = l.TenLop;
                khaiGiangDP.Value = l.NgayKhaiGiang;
                hocPhiTXT.Text = l.HocPhi.ToString();
                hocPhanTXT.Text = l.HocPhan.ToString();
                DateTime dt = DateTime.Today;
                TimeSpan ts = l.TKB;
                tkbDP.Value = dt + ts;
                Montxt.Text = l.MonHoc.TenMonHoc;
            }
        }
        void loadInforHVbyMahv(string s)
        {
            List<HocVien> h = ctrHV.findHVByMaHv(cbmahv.Text);
            if (h.Count <1 && cbmahv.ReadOnly == false)
            {
                MessageBox.Show("Không tìm thấy học viên này!", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmahv.Text = "";
                return;
            }
            foreach (var  hv in h)
            {
                hoTenTXT.Text = hv.HoTen;
                ngaySinhDP.Value = hv.NgaySinh;
                ngheNghiepTXT.Text = hv.NgheNghiep;
                noiSinhTXT.Text = hv.NoiSinh;
            }
            
        }
        void loadInforHVbyName(string name)
        {
            List<HocVien> hv = ctrHV.FindHVByName(name);
            if (hv.Count > 1)
            {
                MessageBox.Show("Hiện tại đang có 2 học viên trùng tên nhau gây xung đột dữ liệu bạn nên chỉnh sửa lại dữ liệu lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult rss = MessageBox.Show("Bạn có muốn tìm bằng mã học viên ??!", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rss == DialogResult.Yes)
                {
                    cbmahv.ReadOnly = false;
                    hoTenTXT.Text = "";
                }
                return;
            }else
            {
                foreach (var i in hv)
                {
                    cbmahv.Text = i.MaHocVien.ToString();
                    ngaySinhDP.Value = i.NgaySinh;
                    ngheNghiepTXT.Text = i.NgheNghiep;
                    noiSinhTXT.Text = i.NoiSinh;
                }
            }
            
        }
        void loadInforLopbyName(string n)
        {
            List<Lop> l = ctrClass.findLopByName(n);
            if (l.Count > 1)
            {
                MessageBox.Show("Hiện tại đang có 2 lớp trùng tên nhau gây xung đột dữ liệu bạn nên chỉnh sửa lại dữ liệu lớp học hoặc tìm kiếm bằng mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                foreach (var i in l)
                {
                    maLopcb.Text = i.MaLop.ToString();
                    khaiGiangDP.Value = i.NgayKhaiGiang;
                    hocPhiTXT.Text = i.HocPhi.ToString();
                    hocPhanTXT.Text = i.HocPhan.ToString();
                    DateTime dt = DateTime.Today;
                    TimeSpan ts = i.TKB;
                    tkbDP.Value = dt + ts;
                    Montxt.Text = i.MonHoc.TenMonHoc;
                }
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
            if (rs.ToList().Count < 1)
            {
                MessageBox.Show("Danh sách rỗng !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        
        private void huyDangKyBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn muốn hủy đăng ký ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (cbmahv.Text =="" || maLopcb.Text =="")
                {
                    MessageBox.Show("Oops! Đã xảy ra lỗi !! Bạn có chắc chắn rằng mọi dữ liệu bạn nhập đều đã chính xác ?!!!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ctrTG.RemoveLopTheoHV(cbmahv.Text, maLopcb.Text);
                    //loadCbMaLop();
                    paneltongsl.Visible = false;
                }
            }
        }

        private void dangKyBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn muốn đăng ký ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                paneltongsl.Visible = false;
                try
                {
                    if (checkHsToLop(int.Parse(cbmahv.Text)) == false)
                    {
                        MessageBox.Show("Học viên đã tham gia lớp này !", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ctrTG.addHsToLop(cbmahv.Text, maLopcb.Text);
                        HocVien hv = ctrHV.FindHV(cbmahv.Text);
                        ctrBL.AddBLDK(hv, double.Parse(hocPhiTXT.Text), int.Parse(maLopcb.Text));
                    }
                }
                catch 
                {
                        MessageBox.Show("Oops! Đã xảy ra lỗi !! Bạn có chắc chắn rằng mọi dữ liệu bạn nhập đều đã chính xác ?!!!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool checkHsToLop(int mahv)
        {
          List<HocVien> lst = loadFindKG().Where(t => t.MaHocVien == mahv).ToList();
            if (lst.Count >= 1) return false;
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

            if (cbmahv.ReadOnly == false)
            {
                loadInforHVbyMahv(cbmahv.Text);
                cbmahv.ReadOnly = true;
            }
            
        }
        private void tenLopTXT_Leave(object sender, EventArgs e)
        {
      
                loadInforLopbyName(tenLopTXT.Text);

        }
        
        private void hoTenTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ctrHV.FindHVByName(hoTenTXT.Text).Count <1)
                {
                       MessageBox.Show("Oops! Không tìm thấy học viên này !! Bạn có chắc chắn rằng mọi dữ liệu bạn nhập đều đã chính xác ?!!!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    loadInforHVbyName(hoTenTXT.Text);

            }
        }

        private void tenLopTXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ctrClass.findLopByName(tenLopTXT.Text).Count < 1)
                {
                    MessageBox.Show("Oops! Không tìm thấy lớp học này !! Bạn có chắc chắn rằng mọi dữ liệu bạn nhập đều đã chính xác ?!!!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else loadInforLopbyName(tenLopTXT.Text);
            }
        }

        private void hoTenTXT_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể tìm kiếm thông tin học viên bằng cách ghi đầy đủ họ tên có dấu";
        }

        private void hoTenTXT_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";

        }

        private void tenLopTXT_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể tìm kiếm thông tin lớp học bằng cách ghi chữ cái đầu tiên của tên lớp";

        }

        private void dangKyBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể đăng ký lớp học cho học viên";

        }

        private void huyDangKyBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể hủy đăng ký lớp học cho học viên";

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể tìm danh sách những học viên khai giảng khóa ngày nào đó ( sử dụng khung lựa chọn ngày tháng ở phần lớp )";

        }

        private void LapDsHvCuaMotLop_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể tìm danh sách những học viên của một lớp học ngày nào đó ( sử dụng khung lựa chọn tên hoặc mã lớp ở phần lớp )";

        }

        private void ChoBietSLHVKGKhoaNgayNaoDo_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể biết số lượng học viên của mỗi lớp khai giảng khóa ngày nào đó ( sử dụng khung lựa chọn ngày tháng và mã hoặc tên lớp ở phần lớp )";

        }

        private void cbmahv_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể tìm kiếm thông tin học viên bằng cách ghi mã học viên";

        }

        private void maLopcb_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Bạn có thể tìm kiếm thông tin lớp học bằng cách lựa chọn mã lớp";

        }

        private void maLopcb_Leave(object sender, EventArgs e)
        {
            loadInforLop();

        }

        private void maLopcb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ctrClass.findLopByMaLop(maLopcb.Text).Count < 1)
                {
                    MessageBox.Show("Oops! Không tìm thấy lớp học này !! Bạn có chắc chắn rằng mọi dữ liệu bạn nhập đều đã chính xác ?!!!", "Thông báo !!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else loadInforLop();
            }
        }

        private void cbmahv_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && cbmahv.ReadOnly == false)
            {
                loadInforHVbyMahv(cbmahv.Text);
                cbmahv.ReadOnly = true;
            }
        }
    }
}
