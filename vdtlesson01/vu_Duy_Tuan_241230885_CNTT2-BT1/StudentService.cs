using System;
using System.Collections.Generic;
using System.Linq;

namespace vu_Duy_Tuan_241230885_CNTT2_BT1
{
    internal class StudentService
    {
        // Danh sách sinh viên
        private List<Student> students = new List<Student>();

        // Thêm sinh viên
        public bool AddStudent(Student student)
        {
            // Kiểm tra mã sinh viên đã tồn tại chưa
            if (students.Any(s => s.MaSV == student.MaSV))
            {
                return false;
            }

            // Thêm sinh viên vào danh sách
            students.Add(student);

            return true;
        }
        // Lấy toàn bộ danh sách sinh viên
        public List<Student> GetAllStudents()
        {
            return students;
        }
        // Tìm sinh viên theo mã
        public Student? FindById(string maSV)
        {
            return students.FirstOrDefault(s => s.MaSV == maSV);
        }
        // Tìm gần đúng theo họ tên
        public List<Student> SearchByName(string keyword)
        {
            return students
                .Where(s => s.HoTen.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        // Cập nhật sinh viên
        public bool UpdateStudent(Student student)
        {
            Student? existingStudent = FindById(student.MaSV);

            // Không tìm thấy sinh viên
            if (existingStudent == null)
            {
                return false;
            }

            existingStudent.HoTen = student.HoTen;
            existingStudent.NgaySinh = student.NgaySinh;
            existingStudent.GioiTinh = student.GioiTinh;
            existingStudent.Email = student.Email;
            existingStudent.SoDienThoai = student.SoDienThoai;
            existingStudent.NganhHoc = student.NganhHoc;
            existingStudent.DTB = student.DTB;
            existingStudent.TrangThai = student.TrangThai;

            return true;
        }
        // Xóa sinh viên theo mã
        public bool DeleteStudent(string maSV)
        {
            Student? student = FindById(maSV);

            // Không tìm thấy sinh viên
            if (student == null)
            {
                return false;
            }

            students.Remove(student);

            return true;
        }
        // Sắp xếp sinh viên theo họ tên
        public List<Student> SortByName()
        {
            return students
                .OrderBy(s => s.HoTen)
                .ToList();
        }
        // Sắp xếp sinh viên theo điểm trung bình giảm dần
        public List<Student> SortByDtb()
        {
            return students
                .OrderByDescending(s => s.DTB)
                .ToList();
        }
        // Lấy sinh viên có điểm trung bình từ 8 trở lên
        public List<Student> GetStudentsWithDtbFrom8()
        {
            return students
                .Where(s => s.DTB >= 8)
                .ToList();
        }
        // Lấy sinh viên có điểm trung bình cao nhất
        public Student? GetHighestDtb()
        {
            return students
                .OrderByDescending(s => s.DTB)
                .FirstOrDefault();
        }
        // Tính điểm trung bình của toàn bộ sinh viên
        public float GetAverageDtb()
        {
            if (students.Count == 0)
            {
                return 0;
            }

            return students.Average(s => s.DTB);
        }
        // Thống kê sinh viên theo ngành
        public Dictionary<string, int> CountByMajor()
        {
            return students
                .GroupBy(s => s.NganhHoc)
                .ToDictionary(
                    group => group.Key,
                    group => group.Count()
                );
        }
        // Thống kê sinh viên theo trạng thái
        public Dictionary<string, int> CountByStatus()
        {
            return students
                .GroupBy(s => s.TrangThai)
                .ToDictionary(
                    group => group.Key,
                    group => group.Count()
                );
        }

    }
}