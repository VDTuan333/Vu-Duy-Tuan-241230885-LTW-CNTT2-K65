using System.Text.RegularExpressions;

namespace vu_Duy_Tuan_241230885_CNTT2_BT1
{
    internal class StudentValidator
    {
        // Kiểm tra họ tên
        public static bool IsValidFullName(string hoTen)
        {
            return !string.IsNullOrWhiteSpace(hoTen);
        }

        // Kiểm tra điểm trung bình
        public static bool IsValidDtb(float dtb)
        {
            return dtb >= 0 && dtb <= 10;
        }

        // Kiểm tra email
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(
                email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
        }
    }
}