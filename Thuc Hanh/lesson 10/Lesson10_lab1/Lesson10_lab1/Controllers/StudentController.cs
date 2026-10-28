using Lesson10_lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson10_lab1.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController()
        {
            listStudents=new List<Student>()
            {
                new Student() { Id = 101, Name = "Hai Nam", Branch = Branch. IT,
                Gender = Gender.Male, IsRegular=true,
                Address = "A1-2018", Email = "nam@g.com" },
                new Student() { Id = 102, Name = "Minh Tu", Branch = Branch.BE,
                Gender = Gender. Female, IsRegular=true,
                Address = "A1-2019", Email = "tu@g.com" },
                new Student() { Id = 103, Name = "Hoang Phong", Branch = Branch. CE,
                Gender = Gender.Male, IsRegular=false,
                Address = "A1-2020", Email = "phong@g.com" },
                new Student() { Id = 104, Name = "Xuan Mai", Branch = Branch.EE,
                Gender = Gender.Female, IsRegular = false,
                Address = "A1-2021", Email = "mai@g.com" }
            };
        }
        
        public IActionResult Index()
        {
            return View(listStudents);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Lấy danh sách cac gia trị Gender để hien thị radio button trên form
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            //Lấy danh sách các gia trị Branch để hien thị select-option trên form
            //Để hien thị select-option trên View cần dùng List<SelectListItem>
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem { Text = "IT", Value = "1" },
                new SelectListItem { Text = "BE", Value = "2" },
                new SelectListItem { Text = "CE", Value = "3" },
                new SelectListItem { Text = "EE", Value = "4" }
            };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(s);
            return View("Index", listStudents);
        }
    }
}
