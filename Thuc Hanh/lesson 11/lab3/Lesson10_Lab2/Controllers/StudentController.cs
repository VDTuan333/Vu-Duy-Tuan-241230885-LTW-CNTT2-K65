using Lesson10_Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Lesson10_Lab2.Controllers
{
    public class StudentController : Controller
    {
        private static readonly List<Student> listStudents = new();
        public StudentController()
        {
            //Tạo danh sách sinh viên với 4 dữ liệu mẫu (chỉ một lần cho dữ liệu in-memory)
            if (listStudents.Count == 0)
            {
                listStudents.AddRange(new[]
                {
                    new Student() { Id = 101, Name = "Hải Nam", Branch = Branch.IT,
                        Gender = Gender.Male, IsRegular=true,
                        Address = "A1-2018", Email = "nam@g.com" },
                    new Student() { Id = 102, Name = "Minh Tú", Branch = Branch.BE,
                        Gender = Gender.Female, IsRegular=true,
                        Address = "A1-2019", Email = "tu@g.com" },
                    new Student() { Id = 103, Name = "Hoàng Phong", Branch = Branch.CE,
                        Gender = Gender.Male, IsRegular=false,
                        Address = "A1-2020", Email = "phong@g.com" },
                    new Student() { Id = 104, Name = "Xuân Mai", Branch = Branch.EE,
                        Gender = Gender.Female, IsRegular = false,
                        Address = "A1-2021", Email = "mai@g.com" }
                });
            }
        }
        // Keep the original admin URL and also expose the conventional URL
        // used by the default MVC route: /Student/Index.
        [HttpGet]
        [Route("Student/Index")]
        [Route("Admin/Student/List", Name = "Route_StudentList")]
        public IActionResult Index()
        {
            //Trả về View Index.cshtml cùng Model là danh sách sv listStudents
            return View(listStudents);
        }
        [HttpGet]
        [Route("Admin/Student/Add", Name = "Route_StudentAdd")]
        public IActionResult Create()
        {
            PopulateCreateViewData();
            return View(new Student());
        }

        [HttpPost]
        [Route("Admin/Student/Add")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = listStudents.Count == 0 ? 1 : listStudents.Max(student => student.Id) + 1;
                listStudents.Add(s);
                return RedirectToAction(nameof(Index));
            }

            PopulateCreateViewData();
            return View(s);
        }

        private void PopulateCreateViewData()
        {
            //Lấy danh sách các giá trị Gender để hiển thị radio button trên form
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            //Lấy danh sách các giá trị Branch để hiển thị select-option trên form
            //Để hiển thị select-option trên View cần dùng List<SelectListItem>
            ViewBag.AllBranches = new List<SelectListItem>()
        {
        new SelectListItem { Text = "IT", Value = "1" },
        new SelectListItem { Text = "BE", Value = "2" },
        new SelectListItem { Text = "CE", Value = "3" },
        new SelectListItem { Text = "EE", Value = "4" }
        };
        }


    }
}