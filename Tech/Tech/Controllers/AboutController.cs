using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Tech.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutRepository());
        ContactManager contactManager = new ContactManager(new EFContactRepository());
        ServiceManager serviceManager = new ServiceManager(new EFServiceRepository());
        public IActionResult Index()
        {
            var aboutValues = aboutManager.GetListAll();
            var contactValues = contactManager.GetListAll();
            var serviceValues = serviceManager.GetListAll();
            //var aboutValues = aboutManager.GetListAll().Where(a => a.AboutStatus).OrderByDescending(a => a.AboutId).FirstOrDefault();

            var viewModel = new AllEntities
            {
                Abouts = aboutValues,
                Contacts = contactValues,
                Services = serviceValues
            };
            return View(viewModel);
        }
    }
}
