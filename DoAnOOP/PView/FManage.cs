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

namespace DoAnOOP
{
    public partial class FManage : Form
    {   
        ControlHocVien ctrHV = new ControlHocVien();
        ControlBienLai ctrBL = new ControlBienLai();
        ControlClass ctrlLop = new ControlClass();
        Lop lop = null;
        List<Lop> dslop;

        // Khoi tao controller Mon Hoc
        ControlMonHoc ctrlMH = new ControlMonHoc();
        MonHoc mh = null;
        List<MonHoc> dsmh;
        public FManage()
        {
            InitializeComponent();
            loadDSHV();
            dslop = ctrlLop.FindLop();
            lop = dslop[0];
            loadDSLop(dslop);
            loadDSBL();
            LoadDSCbMH();
            LoadDSMonHoc();

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
                           s.SoTietThucHanh
                       };
            if (ctrlMH.FindAllMH().Count != 0)
            LoadBindingMH(ctrlMH.FindAllMH()[0]);
            dgvMon.DataSource = list.ToList();
        }

        void LoadBindingMH(MonHoc mh)
        {
            maMonTXT.Text = mh.MaMonHoc;
            tenMonTXT.Text = mh.TenMonHoc;
            lythuyetMonNUM.Value = mh.SoTietLyThuyet;
            thuchanhMonNUM.Value = mh.SoTietThucHanh;
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
            txtidLop.Text = lop.MaLop;
            txtTenLop.Text = lop.TenLop;
            txtHocPhi.Text = lop.HocPhi.ToString();
            dtpNKG.Value = (DateTime)lop.NgayKhaiGiang;
            /*dtpTKB.Value = s.TKB;*/
            nmrHocPhan.Value = lop.HocPhan;
            lop_monCB.SelectedItem = lop.MaMonHoc;
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
            var list = from s in ctrBL.FindAll() select new {s.MaBL, s.NgayDong, s.SoTien, s.HocVien};
            dgvBienLai.DataSource = list.ToList();
        }
        void loadDSBL(List<BienLai> l)
        {
            var list = from s in l select new { s.MaBL, s.NgayDong, s.SoTien, s.HocVien };
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
            mahvTXT.Text = hv.MaHocVien;
            hotenhvTXT.Text = hv.HoTen;
            ngaysinhhvDP.Value = hv.NgaySinh;
            noisinhhvTXT.Text = hv.NoiSinh;
            nghenghiephvTXT.Text = hv.NgheNghiep;
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
                         s.MaMonHoc
                     };
            dgvLop.DataSource = rs.ToList();
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
                           s.MaMonHoc
                       };
            if (ctrlLop.FindLop().Count != 0)
                LoadDataLop(ctrlLop.FindLop()[0]);
            dgvLop.DataSource = list.ToList();
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
            s.MaLop = txtidLop.Text;
            s.TenLop = txtTenLop.Text;
            s.NgayKhaiGiang = dtpNKG.Value.Date;
        /*    s.TKB = dtpTKB.Value.Date;*/
            s.HocPhan = int.Parse(nmrHocPhan.Value+"");
            s.HocPhi = float.Parse(txtHocPhi.Text);
            ctrlLop.update(s);
            LoadDSLop();
        }

        private void themlopBTN_Click(object sender, EventArgs e)
        {
            Lop check = ctrlLop.DefineLop(txtidLop.Text);
            if (check == null)
            {
                try
                {
                    Lop blop = new Lop {
                                    MaLop = txtidLop.Text,
                                    TenLop = txtTenLop.Text,
                                    NgayKhaiGiang = dtpNKG.Value,
                                    HocPhan = (int)nmrHocPhan.Value,
                                    HocPhi = float.Parse(txtHocPhi.Text),
                    };
                    ctrlLop.add(blop);      
                    LoadDSLop();
                }
                catch 
                {
                    MessageBox.Show("Trung ma lop");
                }
            }
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lay gia tri vi tri
            int i = dgvLop.CurrentCell.RowIndex;
            string malop = dgvLop.Rows[i].Cells[0].Value + "";

            // Show thong tin lop dang chon
            lop = dslop.Where(t => t.MaLop == malop).ToList()[0];
            LoadDataLop(lop);

        }

        private void themhvBTN_Click(object sender, EventArgs e)
        {
            HocVien check = ctrHV.FindHV(mahvTXT.Text);
            if (check == null)
            {
                HocVien hv = new HocVien { MaHocVien = mahvTXT.Text, HoTen = hotenhvTXT.Text, NgaySinh = ngaysinhhvDP.Value, NoiSinh = noisinhhvTXT.Text, NgheNghiep = nghenghiephvTXT.Text };
                ctrHV.Add(hv);
                loadDSHV();
            }
            else
            {
                MessageBox.Show("Trùng mã khoa");
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
            /*LoadDSLop(ctrlLop.Asc(ctrlLop.FindLop()));*/
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
            MonHoc mh = new MonHoc {
                MaMonHoc = maMonTXT.Text,
                TenMonHoc = tenMonTXT.Text,
                SoTietLyThuyet = (int)lythuyetMonNUM.Value,
                SoTietThucHanh = (int)thuchanhMonNUM.Value
            };
            ctrlMH.Add(mh);
            LoadDSMonHoc();
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
    }
}
