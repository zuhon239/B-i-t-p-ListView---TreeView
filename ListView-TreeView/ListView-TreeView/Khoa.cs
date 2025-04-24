using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView_TreeView
{
    public class Khoa
    {
        private string maKhoa;        // Mã khoa
        private string tenKhoa;       // Tên khoa
        private string truongKhoa;    // Tên trưởng khoa
        private List<Lop> dsLop;      // Danh sách các lớp thuộc khoa

        public Khoa(string maKhoa, string tenKhoa, string truongKhoa)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.truongKhoa = truongKhoa;
            this.dsLop = new List<Lop>();
        }

        // Thêm một lớp vào khoa
        public void ThemLop(Lop lop)
        {
            this.dsLop.Add(lop);
            lop.Khoa = this;  // Thiết lập mối quan hệ hai chiều
        }

        // Properties
        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }

        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }

        public string TruongKhoa
        {
            get { return truongKhoa; }
            set { truongKhoa = value; }
        }

        public List<Lop> DsLop
        {
            get { return dsLop; }
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

            Khoa other = (Khoa)obj;
            return maKhoa.Equals(other.maKhoa);
        }

        // Override phương thức ToString để hiển thị thông tin đối tượng
        public override string ToString()
        {
            return $"Khoa: {tenKhoa} (Mã: {maKhoa})";
        }
    }

}
