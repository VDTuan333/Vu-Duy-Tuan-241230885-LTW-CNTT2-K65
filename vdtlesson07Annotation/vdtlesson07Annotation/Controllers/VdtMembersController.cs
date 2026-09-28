using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vdtlesson07Annotation.Models;

namespace vdtlesson07Annotation.Controllers
{
    public class VdtMembersController : Controller
    {
        private static List<VdtMember> vdtMembers = new List<VdtMember>();

        // GET: VdtMembersController
        public ActionResult Index()
        {
            return View(vdtMembers);
        }

        // GET: VdtMembersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VdtMembersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VdtMembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VdtMember vdtMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(vdtMember);
                }

                vdtMembers.Add(vdtMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VdtMembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VdtMembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VdtMembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VdtMembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
