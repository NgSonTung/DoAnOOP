﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnOOP.PControl;

namespace DoAnOOP
{
    public partial class FManage : Form
    {   
        ControlHocVien ctrHV = new ControlHocVien();
        ControlBienLai ctrBL = new ControlBienLai();
        ControlClass ctrlLop = new ControlClass();

        // Khoi tao controller Mon Hoc
        ControlMonHoc ctrlMH = new ControlMonHoc();
        public FManage()
        {
            InitializeComponent();
            loadDSHV();
            LoadDSLop();
            loadDSBL();
            LoadDSCbMH();
            LoadDSMonHoc();
            dgvHV.Columns[0].Visible = false;
            dgvLop.Columns[0].Visible = false;
            dgvMon.Columns[0].Visible = false;
        }

        #region cap thuc (binding data tu dgv vao txt)

        void LoadDSMonHoc()
        {
            var list = from s in ctrlMH.FindAllMH()
                       select new
                       {
                           s.MaMonHoc,
                           s.TenMonHoc,
                           s.SoTietLyThuyet,
                           s.SoTietThucHanh,
                       };
            if (ctrlMH.FindAllMH().Count != 0)
            LoadBindingMH(ctrlMH.FindAllMH()[0]);
            dgvMon.DataSource = list.ToList();
        }

        void LoadBindingMH(MonHoc mh)
        {
            tenMonTXT.Text = mh.TenMonHoc;
            lythuyetMonNUM.Value = mh.SoTietLyThuyet;
            thuchanhMonNUM.Value = mh.SoTietThucHanh;
        }
        bool CheckMon(string tenMon)
        {
            bool result = true;
            foreach(var mon in ctrlMH.FindAllMH())
            {
                if (tenMon == mon.TenMonHoc)
                    result = false;
            }
            return result;
        }

        void LoadDSMonHoc(List<MonHoc> lstMH)
        {
            var lst = from s in lstMH
                      select new
                      {
                          s.MaMonHoc,
                          s.TenMonHoc,
                          s.SoTietLyThuyet,
                          s.SoTietThucHanh
                      };
            dgvMon.DataSource = lst.ToList();
        }

        void LoadDataLop(Lop lop)
        {
            txtTenLop.Text = lop.TenLop;
            txtHocPhi.Text = lop.HocPhi.ToString();
            dtpNKG.Value = (DateTime)lop.NgayKhaiGiang;
            DateTime dt = DateTime.Today;
            TimeSpan ts = lop.TKB;
            dtpTKB.Value = dt + ts;
            nmrHocPhan.Value = lop.HocPhan;
            lop_monCB.Text = lop.MonHoc.TenMonHoc;
        }

        void LoadDataIdMH(MonHoc mh)
        {
            lop_monCB.DataSource = mh.TenMonHoc;
        }

        #endregion

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        void loadDSBL()
        {
            var list = from s in ctrBL.FindAll() select new {s.MaBL, s.NgayDong, s.SoTien, s.HocVien.HoTen, s.Lop.TenLop};
            dgvBienLai.DataSource = list.ToList();
        }
        void loadDSBL(List<BienLai> l)
        {
            var list = from s in l select new { s.MaBL, s.NgayDong, s.SoTien, s.HocVien.HoTen, s.Lop.TenLop };
                dgvBienLai.DataSource = list.ToList();
        }

        void loadDSHV()
        {
            var list = from s in ctrHV.FindAll() select new {s.MaHocVien , s.HoTen, s.NgaySinh, s.NoiSinh, s.NgheNghiep };
            if (ctrHV.FindAll().Count != 0)
                loadHV(ctrHV.FindAll()[0]);
            dgvHV.DataSource = list.ToList();
        }

        void loadDSHV(List<HocVien> l)
        {
            var list = from s in l select new { s.MaHocVien, s.HoTen, s.NgaySinh, s.NoiSinh, s.NgheNghiep };
            if (ctrHV.FindAll().Count != 0)
                loadHV(ctrHV.FindAll()[0]);
            dgvHV.DataSource = list.ToList();
        }

        void loadHV(HocVien hv)
        {
            hotenhvTXT.Text = hv.HoTen;
            ngaysinhhvDP.Value = hv.NgaySinh;
            noisinhhvTXT.Text = hv.NoiSinh;
            nghenghiephvTXT.Text = hv.NgheNghiep;
        }

        void LoadDSLop()
        {
            var list = from s in ctrlLop.FindLop()
                        select new
                        {
                            s.MaLop,
                            s.TenLop,
                            s.NgayKhaiGiang,
                            s.TKB,
                            s.HocPhan,
                            s.HocPhi,
                            s.MaMonHoc,
                            s.MonHoc.TenMonHoc
                        };
            if (ctrlLop.FindLop().Count != 0)
                LoadDataLop(ctrlLop.FindLop()[0]);
            dgvLop.DataSource = list.ToList();
        }
        // TAB Lop
        void loadDSLop(List<Lop> lst)
        {   
            var rs = from s in lst
                     select new
                     {
                         s.MaLop,
                         s.TenLop,
                         s.TKB,
                         s.NgayKhaiGiang,
                         s.HocPhan,
                         s.HocPhi,
                         s.MaMonHoc,
                         s.MonHoc.TenMonHoc
                     };

            if (ctrlLop.FindLop().Count != 0)
            LoadDataLop(ctrlLop.FindLop()[0]);
            dgvLop.DataSource = rs.ToList();
        }

        void BindingCBMH(MonHoc mh)
        {
            lop_monCB.Text = mh.TenMonHoc;
        }

        void LoadDSCbMH()
        {
            List<MonHoc> dsmonhoc = ctrlMH.FindAllMH();
            lop_monCB.DataSource = dsmonhoc;
            
            
        }

        // END TAB LOP

        private void capnhatlopBTN_Click(object sender, EventArgs e)
        {
            // Xac dinh vi tri can update
            int index = dgvLop.CurrentCell.RowIndex;
            string lop = dgvLop.Rows[index].Cells[0].Value + "";

            Lop s = ctrlLop.DefineLop(lop); // Tim kiem lop can thay doi
            s.TenLop = txtTenLop.Text;
            s.NgayKhaiGiang = dtpNKG.Value.Date;
            s.TKB = dtpTKB.Value.TimeOfDay;
            s.HocPhan = int.Parse(nmrHocPhan.Value+"");
            s.HocPhi = float.Parse(txtHocPhi.Text);
            ctrlLop.update(s);
            LoadDSLop();
        }

        bool CheckLop()
        {
            bool result = true;
            foreach(var lop in ctrlLop.FindLop())
            {
                if (lop.TenLop == txtTenLop.Text)
                    result = false;
            }
            return result;
        }

        private void themlopBTN_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text != "" && txtHocPhi.Text != "" && lop_monCB.SelectedItem != null && CheckLop())
            {
                Lop blop = new Lop
                {
                    TenLop = txtTenLop.Text,
                    NgayKhaiGiang = dtpNKG.Value,
                    HocPhan = (int)nmrHocPhan.Value,
                    TKB = dtpTKB.Value.TimeOfDay,
                    HocPhi = float.Parse(txtHocPhi.Text),
                    MaMonHoc = (lop_monCB.SelectedItem as MonHoc).MaMonHoc
                    // ép kiểu giá trị cmb và lấy mã môn học dựa trên giá trị cmb
                };
                ctrlLop.add(blop);
                LoadDSLop();
                txtTenLop.Clear();
                txtHocPhi.Clear();
            }
            else
                MessageBox.Show("Hãy nhập lại thông tin");
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lay gia tri vi tri
            int i = dgvLop.CurrentCell.RowIndex;
            string malop = dgvLop.Rows[i].Cells[0].Value + "";

            // Show thong tin lop dang chon
            if (ctrlLop.DefineLop(malop) != null)
            {
                LoadDataLop(ctrlLop.DefineLop(malop));
            }

            /*string mamh = dgvLop.Rows[i].Cells["MaMonHoc"].Value + "";

            lop_monCB.Text = mamh;*/

        }

        private void themhvBTN_Click(object sender, EventArgs e)
        {   
            if(hotenhvTXT.Text != "" && noisinhhvTXT.Text != "" && nghenghiephvTXT.Text != "")
            {
                HocVien hv = new HocVien {HoTen = hotenhvTXT.Text, NgaySinh = ngaysinhhvDP.Value, NoiSinh = noisinhhvTXT.Text, NgheNghiep = nghenghiephvTXT.Text };
                ctrHV.Add(hv);
                loadDSHV();
                hotenhvTXT.Clear();
                noisinhhvTXT.Clear();
                nghenghiephvTXT.Clear();
            }
            else
            {
                MessageBox.Show("Hãy nhập lại thông tin");
            }
        }

        private void dgvHV_SelectionChanged(object sender, EventArgs e)
        {
            int index = dgvHV.CurrentCell.RowIndex;
            string id = dgvHV.Rows[index].Cells[0].Value + "";
            if (ctrHV.FindHV(id) != null)
            loadHV(ctrHV.FindHV(id));
        }

        private void xoahvBTN_Click(object sender, EventArgs e)
        {
            int index = dgvHV.CurrentCell.RowIndex;
            string id = dgvHV.Rows[index].Cells[0].Value + "";
            ctrHV.Delete(ctrHV.FindHV(id));
            loadDSHV();
        }

        private void lietkehvBTN_Click(object sender, EventArgs e)
        {
            loadDSHV(ctrHV.AscHV(ctrHV.FindAll()));

        }

        private void xemhvBTN_Click(object sender, EventArgs e)
        {
            loadDSHV();
        }

        private void capnhathvBTN_Click(object sender, EventArgs e)
        {
            int index = dgvHV.CurrentCell.RowIndex;
            string id = dgvHV.Rows[index].Cells[0].Value + "";
            HocVien hv = ctrHV.FindHV(id);
            hv.HoTen = hotenhvTXT.Text;
            hv.NgaySinh = ngaysinhhvDP.Value;
            hv.NoiSinh = noisinhhvTXT.Text;
            hv.NgheNghiep = nghenghiephvTXT.Text;
            ctrHV.Update(hv);
            loadDSHV();
        }

        private void timKiemHVBTN_Click(object sender, EventArgs e)
        {
            loadDSHV(ctrHV.SearchHV(timKiemHVTXT.Text));
        }

        private void themhvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Thêm học viên vào danh sách";
        }

        private void xoahvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Xóa học viên khỏi danh sách";
        }

        private void capnhathvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Cập nhật thông tin học viên";
        }

        private void lietkehvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Sắp xếp học viên theo ngày sinh tăng dần";
        }

        private void timKiemHVBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Tìm kiếm học viên theo mã, tên hoặc nơi sinh";
        }

        private void xemhvBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Xuất danh sách học viên gốc";
        }

        private void themhvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xoahvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void capnhathvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void lietkehvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void timKiemHVBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xemhvBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanHVTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin f = new FAdmin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void xoalopBTN_Click(object sender, EventArgs e)
        {
            int index = dgvLop.CurrentCell.RowIndex;
            string idlop = dgvLop.Rows[index].Cells[0].Value + "";
            ctrlLop.delete(ctrlLop.DefineLop(idlop));
            LoadDSLop();
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            loadDSLop(ctrlLop.AscLop(ctrlLop.FindLop()));
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMon.CurrentCell.RowIndex;
            string mamh = dgvMon.Rows[index].Cells[0].Value + "";
            if(ctrlMH.FindMH(mamh) != null)
            {
                LoadBindingMH(ctrlMH.FindMH(mamh));
            }
              
        }

        private void themMonBTN_Click(object sender, EventArgs e)
        {   
            if (CheckMon(tenMonTXT.Text))
            {
                MonHoc mh = new MonHoc
                {
                    TenMonHoc = tenMonTXT.Text,
                    SoTietLyThuyet = (int)lythuyetMonNUM.Value,
                    SoTietThucHanh = (int)thuchanhMonNUM.Value
                };
                ctrlMH.Add(mh);
                LoadDSMonHoc();
            }
            else
                MessageBox.Show("Trùng tên môn học");

        }

        private void hienThiBienLaiBTN_Click(object sender, EventArgs e)
        {
            loadDSBL(ctrBL.FindBL(dateFrom.Value, dateTo.Value));
        }

        private void timKiemBienLaiBTN_Click(object sender, EventArgs e)
        {   
            loadDSBL(ctrBL.SearchBL(timKiemBienLaiTXT.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDSBL();
        }

        private void sapXepBLBTN_Click(object sender, EventArgs e)
        {
            loadDSBL(ctrBL.DescBL(ctrBL.FindAll()));
        }

        private void hienThiBienLaiBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanBLTXT.Text = "Hiển thị danh sách biên lai trong khoảng ngày đã chọn";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            huongDanBLTXT.Text = "Hiển thị danh sách toàn bộ biên lai";
        }

        private void timKiemBienLaiBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanBLTXT.Text = "Hiển thị danh sách biên lai theo mã biên lai hoặc mã học viên";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hienThiBienLaiBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanBLTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void timKiemBienLaiBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanBLTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            huongDanBLTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void sapXepBLBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanBLTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void sapXepBLBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanBLTXT.Text = "Sắp xếp danh sách từ ngày gần nhất";
        }

        private void xoaMonBTN_Click(object sender, EventArgs e)
        {
            int index = dgvMon.CurrentCell.RowIndex;
            string mamh = dgvMon.Rows[index].Cells[0].Value + "";
            ctrlMH.Delete(ctrlMH.FindMH(mamh));
            LoadDSMonHoc();
        }

        private void capNhatMon_Click(object sender, EventArgs e)
        {
            int index = dgvMon.CurrentCell.RowIndex;
            string mamh = dgvMon.Rows[index].Cells[0].Value + "";
            MonHoc mh = ctrlMH.FindMH(mamh);
            mh.TenMonHoc = tenMonTXT.Text;
            mh.SoTietLyThuyet = (int)lythuyetMonNUM.Value;
            mh.SoTietThucHanh = (int)thuchanhMonNUM.Value;
            ctrlMH.Update(mh);
            LoadDSMonHoc();
        }

        private void timKiemMonBTN_Click(object sender, EventArgs e)
        {
            LoadDSMonHoc(ctrlMH.SubjectSearching(timKiemMonTXT.Text));
        }

        private void xemMonBTN_Click(object sender, EventArgs e)
        {
            LoadDSMonHoc();
        }

        private void timkiemlopBTN_Click(object sender, EventArgs e)
        {
            loadDSLop(ctrlLop.TimKiemLop(timkiemlopTXT.Text));
        }

        private void huongDanHVTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void themlopBTN_MouseHover(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Thêm lớp vào danh sách ";
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void themlopBTN_MouseLeave(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xoalopBTN_MouseHover(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Xóa lớp trong danh sách";
        }

        private void xoalopBTN_MouseLeave(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void capnhatlopBTN_MouseHover(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Cập nhật danh sách lớp";
        }

        private void capnhatlopBTN_MouseLeave(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void btnAsc_MouseHover(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Sắp xếp lớp khai giảng từ gần đến xa nhất";
        }

        private void btnAsc_MouseLeave(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void timkiemlopBTN_MouseHover(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Tìm kiếm lớp theo mã hoặc tên lớp";
        }

        private void timkiemlopBTN_MouseLeave(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Hover nút bất kì để hiện hướng dẫn";

        }

        private void xemLopBTN_MouseHover(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Xem tất cả lớp trong danh sách";
        }

        private void xemLopBTN_MouseLeave(object sender, EventArgs e)
        {
            txtHuongDan.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xemLopBTN_Click(object sender, EventArgs e)
        {
            LoadDSLop();
        }

        private void themMonBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Thêm môn vào danh sách";
        }

        private void xoaMonBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Xóa môn khỏi danh sách";
        }

        private void capNhatMon_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Cập nhật thông tin môn học";
        }

        private void timKiemMonBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Xuất danh sách môn theo mã môn hoặc tên môn";
        }

        private void xemMonBTN_MouseHover(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Xuất danh sách tất cả môn học";
        }

        private void themMonBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xoaMonBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void capNhatMon_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void timKiemMonBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void xemMonBTN_MouseLeave(object sender, EventArgs e)
        {
            huongDanMonTXT.Text = "Hover nút bất kì để hiện hướng dẫn";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
