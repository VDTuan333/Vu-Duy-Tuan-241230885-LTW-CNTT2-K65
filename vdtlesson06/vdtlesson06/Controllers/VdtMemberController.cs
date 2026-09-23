using Microsoft.AspNetCore.Mvc;
using vdtlesson06.Models;

namespace vdtlesson06.Controllers
{
    public class VdtMemberController : Controller
    {
        //mock data
        private static readonly List<VdtMember> _vdtMembers = new List<VdtMember>()
        {
            new VdtMember()
            {
                VdtMemberID = Guid.NewGuid().ToString(),
                VdtMemberUserName = "tuan",
                VdtMemberPassword = "123456",
                VdtMemberEmail = "tuan01@gmail.com",
                VdtMemberFullName = "Vu Duy Tuan"
            },

            new VdtMember()
            {
                VdtMemberID = Guid.NewGuid().ToString(),
                VdtMemberUserName = "nam02",
                VdtMemberPassword = "123456",
                VdtMemberEmail = "nam02@gmail.com",
                VdtMemberFullName = "Nguyen Van Nam"
            },

            new VdtMember()
            {
                VdtMemberID = Guid.NewGuid().ToString(),
                VdtMemberUserName = "an03",
                VdtMemberPassword = "123456",
                VdtMemberEmail = "an03@gmail.com",
                VdtMemberFullName = "Tran Van An"
            },

            new VdtMember()
            {
                VdtMemberID = Guid.NewGuid().ToString(),
                VdtMemberUserName = "binh04",
                VdtMemberPassword = "123456",
                VdtMemberEmail = "binh04@gmail.com",
                VdtMemberFullName = "Le Van Binh"
            },

            new VdtMember()
            {
                VdtMemberID = Guid.NewGuid().ToString(),
                VdtMemberUserName = "hoa05",
                VdtMemberPassword = "123456",
                VdtMemberEmail = "hoa05@gmail.com",
                VdtMemberFullName = "Pham Thi Hoa"
            }
        };
        //get: List
        public IActionResult VdtIndex()
        {
            return View(_vdtMembers);
        }
        /// <summary>
        /// Create 
        /// </summary>
        /// <returns></returns>
        /// 

        public IActionResult VdtCreate()
        {
            return View();
        }

        /// <summary>
        /// create - submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult VdtCreate(VdtMember vdtMember)
        {
            vdtMember.VdtMemberID = Guid.NewGuid().ToString();
            _vdtMembers.Add(vdtMember);
            return RedirectToAction("VdtIndex");
        }
        /// <summary>
        /// VdtEdit
        /// </summary>
        /// <returns></returns>
        /// 
        public IActionResult VdtEdit(string id)
        {
            var vdtMember = _vdtMembers.FirstOrDefault(x=>x.VdtMemberID.Equals(id));
            return View(vdtMember);
        }
        /// <summary>
        /// edit - submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult VdtEdit(string id, VdtMember vdtMember)
        {
            for (int i = 0; i < _vdtMembers.Count; i++)
            {
                if (_vdtMembers[i].VdtMemberID == id)
                {
                    _vdtMembers[i].VdtMemberID = vdtMember.VdtMemberID;
                    _vdtMembers[i].VdtMemberUserName = vdtMember.VdtMemberUserName;
                    _vdtMembers[i].VdtMemberPassword = vdtMember.VdtMemberPassword;
                    _vdtMembers[i].VdtMemberFullName = vdtMember.VdtMemberFullName;
                    _vdtMembers[i].VdtMemberEmail = vdtMember.VdtMemberEmail;
                    break;
                }
            }
            return RedirectToAction("VdtIndex");
        }
        public IActionResult VdtGetDetails()
        {
            var vdtMember = new VdtMember()
            {
                VdtMemberID = Guid.NewGuid().ToString(),
                VdtMemberUserName = "vuduytuan",
                VdtMemberPassword = "25042006",
                VdtMemberFullName = "vu duy tuan",
                VdtMemberEmail = "vuduytuan25042006@gmail.com"
            };
            return View(vdtMember);
        }
    }
}
