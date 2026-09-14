using System;

namespace vu_Duy_Tuan_241230885_CNTT2_BT1
{
    internal class MenuManager
    {
        private readonly StudentService studentService;
        private readonly StudentConsoleView consoleView;

        public MenuManager()
        {
            studentService = new StudentService();
            consoleView = new StudentConsoleView();
        }

        public void Run()
        {
            int choice;

            do
            {
                ShowMenu();

                Console.Write("Nhập lựa chọn: ");
                choice = int.Parse(Console.ReadLine()!);

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        DisplayAllStudents();
                        break;

                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (choice != 0);
        }

        private void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("========== QUẢN LÝ SINH VIÊN ==========");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Hiển thị danh sách");
            Console.WriteLine("3. Tìm sinh viên theo mã");
            Console.WriteLine("4. Tìm gần đúng theo họ tên");
            Console.WriteLine("5. Cập nhật sinh viên");
            Console.WriteLine("6. Xóa sinh viên");
            Console.WriteLine("7. Sắp xếp theo họ tên");
            Console.WriteLine("8. Sắp xếp theo điểm trung bình");
            Console.WriteLine("9. Hiển thị sinh viên có điểm từ 8 trở lên");
            Console.WriteLine("10. Hiển thị sinh viên có điểm cao nhất");
            Console.WriteLine("11. Tính điểm trung bình toàn bộ");
            Console.WriteLine("12. Thống kê sinh viên theo ngành");
            Console.WriteLine("13. Thống kê sinh viên theo trạng thái");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("========================================");
        }

        private void AddStudent()
        {
            Student student = consoleView.InputStudent();

            bool result = studentService.AddStudent(student);

            if (result)
            {
                Console.WriteLine("Thêm sinh viên thành công!");
            }
            else
            {
                Console.WriteLine("Mã sinh viên đã tồn tại!");
            }
        }

        private void DisplayAllStudents()
        {
            List<Student> students = studentService.GetAllStudents();

            consoleView.DisplayStudents(students);
        }
    }
}