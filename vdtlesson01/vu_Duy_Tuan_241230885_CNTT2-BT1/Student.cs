using System;

namespace vu_Duy_Tuan_241230885_CNTT2_BT1
{
    /// <summary>
    /// Class: Student
    /// Author: Chung Trinhj
    /// </summary>
    internal class Student
    {
        // Properties
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string NganhHoc { get; set; }
        public float DTB { get; set; }
        public string TrangThai { get; set; }

        // Constructor mặc định
        public Student()
        {
        }

        // Constructor có tham số
        public Student(
            string maSV,
            string hoTen,
            DateTime? ngaySinh,
            string gioiTinh,
            string email,
            string soDienThoai,
            string nganhHoc,
            float dtb,
            string trangThai)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Email = email;
            SoDienThoai = soDienThoai;
            NganhHoc = nganhHoc;
            DTB = dtb;
            TrangThai = trangThai;
        }

    }
}