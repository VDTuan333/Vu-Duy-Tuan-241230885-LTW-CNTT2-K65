using Microsoft.AspNetCore.Mvc;
using vdtlesson05ViewComponents.Models;

namespace vdtlesson05ViewComponents.ViewComponents
{
    public class VdtCategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(bool? active)
        {
            var categories =new List<VdtCategory>
            {
                new VdtCategory(){CategoryId=1,CategoryName="dien gia dung",IsActive=true},
                new VdtCategory(){CategoryId=2,CategoryName="iphone",IsActive=true},
                new VdtCategory(){CategoryId=3,CategoryName="book",IsActive=false},
                new VdtCategory(){CategoryId=4,CategoryName="laptop",IsActive=true}
            };

            if(active !=null)
            {
                categories = categories.Where(c => c.IsActive == active).ToList();
            }
           

            return View(categories);
        }
    }
}
