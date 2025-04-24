using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView_TreeView
{
    public class SinhVien
    {
        private string maSV;          // Mã sinh viên
        private string hoTen;         // Họ tên sinh viên
        private string email;         // Email sinh viên
        private DateTime ngaySinh;    // Ngày sinh
        private bool gioiTinh;        // Giới tính (true: Nam, false: Nữ)
        private Lop lop;              // Lớp mà sinh viên thuộc về

        public SinhVien(string maSV, string hoTen, string email, DateTime ngaySinh, bool gioiTinh)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.email = email;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
        }

        // Properties
        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public Lop Lop
        {
            get { return lop; }
            set { lop = value; }
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

            SinhVien other = (SinhVien)obj;
            return maSV.Equals(other.maSV);
        }

        // Override phương thức ToString để hiển thị thông tin đối tượng
        public override string ToString()
        {
            return $"Sinh viên: {hoTen} (Mã: {maSV}, Email: {email})";
        }
    }
}
