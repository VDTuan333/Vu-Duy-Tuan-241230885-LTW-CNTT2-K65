using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace vdtlesson07Annotation.Models
{

    /// <summary>
    /// Model class Member
    /// author: vu duy tuan
    /// </summary>
    public class VdtMember
    {
        public  int ID { get; set; }
        [DisplayName("Tai khoan")]
        [Required(ErrorMessage ="tai khoan khong duoc de trong")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="tai khoan co do dai trong khoang 3-20 ki tu")]
        
        public string VdtUserName { get; set; }
        [DisplayName("mat khau")]
        [StringLength(100,MinimumLength =8,ErrorMessage ="mat khau toi thieu 8 ki tu")]
        public string VdtPassword { get; set; }
        [DisplayName("email")]
        [Required(ErrorMessage ="email khong duoc bo trong ")]
        [DataType(DataType.EmailAddress)]
        public string VdtEmail { get; set; }
        [DisplayName("dien thoai")]
        [Required(ErrorMessage ="ban chua nhap dien thoai")]
        [RegularExpression(@"^0\d{9,9}",ErrorMessage = "So dien thoai phai co 10 chu so va bat dau bang 0")]
        public string VdtPhone { get; set; }
        
    }
}
