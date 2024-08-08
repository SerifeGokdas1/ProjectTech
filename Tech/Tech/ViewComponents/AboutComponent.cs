using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Tech.ViewComponents
{
    public class AboutComponent : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EFAboutRepository());

        public IViewComponentResult Invoke()
        {
            var aboutValue = aboutManager.GetListAll();
            var aboutValues = new AllEntities
            {
                Abouts = aboutValue,
            };

            return View(aboutValues);
        }
    }
}
