using System.ComponentModel.DataAnnotations;

namespace Lesson10_Lab2.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên

        [Required]
        public string? Name { get; set; } //Họ tên

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string? Email { get; set; } //Email

        [StringLength(100, MinimumLength = 8)]
        [Required]
        public string? Password { get; set; }//Mật khẩu

        [Required]
        public Branch? Branch { get; set; }//Ngành học

        [Required]
        public Gender? Gender { get; set; }//Giới tính

        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq

        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }//Địa chỉ

        
        [Required]
        public DateTime DateOfBorth { get; set; }//Ngày sinh
    }
}
