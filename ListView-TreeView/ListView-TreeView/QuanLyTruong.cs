using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView_TreeView
{
    public class QuanLyTruong
    {
        private Dictionary<string, Khoa> dsKhoa;         // Danh sách khoa theo mã khoa
        private Dictionary<string, Lop> dsLop;           // Danh sách lớp theo mã lớp
        private Dictionary<string, SinhVien> dsSinhVien; // Danh sách sinh viên theo mã sinh viên

        public QuanLyTruong()
        {
            this.dsKhoa = new Dictionary<string, Khoa>();
            this.dsLop = new Dictionary<string, Lop>();
            this.dsSinhVien = new Dictionary<string, SinhVien>();
        }

        public void ThemKhoa(Khoa khoa)
        {
            dsKhoa[khoa.MaKhoa] = khoa;
        }

        // Thêm lớp mới và liên kết với khoa
        public void ThemLop(Lop lop, string maKhoa)
        {
            dsLop[lop.MaLop] = lop;
            if (maKhoa != null && dsKhoa.ContainsKey(maKhoa))
            {
                Khoa khoa = dsKhoa[maKhoa];
                khoa.ThemLop(lop);
            }
        }

        // Thêm sinh viên mới và liên kết với lớp
        public void ThemSinhVien(SinhVien sinhVien, string maLop)
        {
            dsSinhVien[sinhVien.MaSV] = sinhVien;
            if (maLop != null && dsLop.ContainsKey(maLop))
            {
                Lop lop = dsLop[maLop];
                lop.ThemSinhVien(sinhVien);
            }
        }

        // Lấy danh sách sinh viên theo lớp
        public List<SinhVien> LaySinhVienTheoLop(string maLop)
        {
            if (dsLop.ContainsKey(maLop))
            {
                return dsLop[maLop].DsSinhVien;
            }
            return new List<SinhVien>();
        }

        // Lấy danh sách lớp theo khoa
        public List<Lop> LayLopTheoKhoa(string maKhoa)
        {
            if (dsKhoa.ContainsKey(maKhoa))
            {
                return dsKhoa[maKhoa].DsLop;
            }
            return new List<Lop>();
        }

        // Lấy thông tin chi tiết sinh viên
        public SinhVien LaySinhVien(string maSV)
        {
            if (dsSinhVien.ContainsKey(maSV))
            {
                return dsSinhVien[maSV];
            }
            return null;
        }

        // Properties cho các danh sách
        public Dictionary<string, Khoa> DsKhoa
        {
            get { return dsKhoa; }
        }

        public Dictionary<string, Lop> DsLop
        {
            get { return dsLop; }
        }

        public Dictionary<string, SinhVien> DsSinhVien
        {
            get { return dsSinhVien; }
        }
    }
}
