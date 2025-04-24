using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView_TreeView
{
    public class Lop
    {
        private string maLop;         // Mã lớp
        private string tenLop;        // Tên lớp
        private Khoa khoa;            // Khoa quản lý lớp
        private SinhVien lopTruong;   // Sinh viên làm lớp trưởng
        private List<SinhVien> dsSinhVien;  // Danh sách sinh viên trong lớp

        public Lop(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.dsSinhVien = new List<SinhVien>();
        }

        // Thêm sinh viên vào lớp
        public void ThemSinhVien(SinhVien sinhVien)
        {
            this.dsSinhVien.Add(sinhVien);
            sinhVien.Lop = this;  // Thiết lập mối quan hệ hai chiều
        }

        // Chỉ định lớp trưởng
        public void ChiDinhLopTruong(SinhVien sinhVien)
        {
            if (this.dsSinhVien.Contains(sinhVien))
            {
                this.lopTruong = sinhVien;
            }
            else
            {
                throw new ArgumentException("Sinh viên không thuộc lớp này");
            }
        }

        // Properties
        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        public Khoa Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }

        public SinhVien LopTruong
        {
            get { return lopTruong; }
        }

        public List<SinhVien> DsSinhVien
        {
            get { return dsSinhVien; }
        }

        // Sử dụng giá trị GetHashCode() cố định 1877310944 làm primary key
        public override int GetHashCode()
        {
            return 1877310944;
        }

        // Override phương thức Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Lop other = (Lop)obj;
            return maLop.Equals(other.maLop);
        }

        // Override phương thức ToString để hiển thị thông tin đối tượng
        public override string ToString()
        {
            return $"Lớp: {tenLop} (Mã: {maLop})";
        }
    }
}
