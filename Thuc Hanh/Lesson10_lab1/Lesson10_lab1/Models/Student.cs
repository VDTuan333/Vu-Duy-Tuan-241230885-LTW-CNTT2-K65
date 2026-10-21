namespace Lesson10_lab1.Models
{
    public class Student
    {
        public string? Name { get; set; } //Họ tên
        public string? Password { get; set; }//Mat khẩu
        public Branch? Branch { get; set; }//Ngành học
        public Gender? Gender { get; set; }//Gioi tinh
        public bool IsRegular { get; set; }//He: true-chinh qui, false-phi cq
        public string? Address { get; set; }//Đia chi
        public DateTime DateOfBorth { get; set; }//Ngày sinh
        public int Id { get; set; }//Ma sinh vien
        public string? Email { get; set; } //Email
    }
}
