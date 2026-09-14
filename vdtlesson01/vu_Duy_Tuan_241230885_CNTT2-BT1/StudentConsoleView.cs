using System;
using System.Collections.Generic;

namespace vu_Duy_Tuan_241230885_CNTT2_BT1
{
    internal class StudentConsoleView
    {
        // Hiển thị thông tin một sinh viên
        public void DisplayStudent(Student student)
        {
            Console.WriteLine($"Mã SV: {student.MaSV}");
            Console.WriteLine($"Họ tên: {student.HoTen}");
            Console.WriteLine($"Ngày sinh: {student.NgaySinh:dd/MM/yyyy}");
            Console.WriteLine($"Giới tính: {student.GioiTinh}");
            Console.WriteLine($"Email: {student.Email}");
            Console.WriteLine($"Số điện thoại: {student.SoDienThoai}");
            Console.WriteLine($"Ngành học: {student.NganhHoc}");
            Console.WriteLine($"Điểm trung bình: {student.DTB}");
            Console.WriteLine($"Trạng thái: {student.TrangThai}");
        }
        // Nhập thông tin sinh viên
        public Student InputStudent()
        {
            Console.Write("Nhập mã sinh viên: ");
            string maSV = Console.ReadLine() ?? "";

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine() ?? "";

            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            DateTime ngaySinh = DateTime.ParseExact(
                Console.ReadLine()!,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture
            );

            Console.Write("Nhập giới tính: ");
            string gioiTinh = Console.ReadLine() ?? "";

            Console.Write("Nhập email: ");
            string email = Console.ReadLine() ?? "";

            Console.Write("Nhập số điện thoại: ");
            string soDienThoai = Console.ReadLine() ?? "";

            Console.Write("Nhập ngành học: ");
            string nganhHoc = Console.ReadLine() ?? "";

            Console.Write("Nhập điểm trung bình: ");
            float dtb = float.Parse(Console.ReadLine()!);

            Console.Write("Nhập trạng thái học tập: ");
            string trangThai = Console.ReadLine() ?? "";

            return new Student(
                maSV,
                hoTen,
                ngaySinh,
                gioiTinh,
                email,
                soDienThoai,
                nganhHoc,
                dtb,
                trangThai
            );
        }
        // Hiển thị danh sách sinh viên
        public void DisplayStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên đang trống.");
                return;
            }

            Console.WriteLine("\n===== DANH SÁCH SINH VIÊN =====");

            foreach (Student student in students)
            {
                DisplayStudent(student);
                Console.WriteLine("------------------------------");
            }
        }
    }
}