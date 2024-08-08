using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Tech.Controllers
{
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EFServiceRepository());
        ServiceHeaderManager serviceHeaderManager = new ServiceHeaderManager(new EFServiceHeaderRepository());
        ContactManager contactManager = new ContactManager(new EFContactRepository());
        AboutManager aboutManager = new AboutManager(new EFAboutRepository());

        public IActionResult Index()
        {
            var serviceValues = serviceManager.GetListAll();
            var serviceHeaderValues = serviceHeaderManager.GetListAll();
            var contactValues = contactManager.GetListAll();
            var aboutValues = aboutManager.GetListAll();

            var viewModel = new AllEntities
            {
                Services = serviceValues,
                ServiceHeaders = serviceHeaderValues,
                Contacts = contactValues,
                Abouts = aboutValues
            };
            return View(viewModel);
        }

        public IActionResult ServiceDetail(int id)
        {
            var values = serviceManager.GetTById(id);
            var contactValues = contactManager.GetListAll();
            var aboutValues = aboutManager.GetListAll();
            var serviceValues = serviceManager.GetListAll();

            var viewModel = new AllEntities
            {
                Contacts = contactValues,
                Abouts = aboutValues,
                Service = values,
                Services = serviceValues
            };

            return View(viewModel);
        }
    }
}
