using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Tech.Controllers
{
    public class HomeController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutRepository());
        ServiceManager serviceManager = new ServiceManager(new EFServiceRepository());
        ServiceHeaderManager serviceHeaderManager = new ServiceHeaderManager(new EFServiceHeaderRepository());
        ContactManager contactManager = new ContactManager(new EFContactRepository());
        SliderManager sliderManager = new SliderManager(new EFSliderRepository());
        public IActionResult Index()
        {
            var aboutValues = aboutManager.GetListAll();
            var serviceValues = serviceManager.GetListAll();
            var contactValues = contactManager.GetListAll();
            var serviceHeaderValues = serviceHeaderManager.GetListAll();
            var sliderValues = sliderManager.GetListAll();

            var viewModel = new AllEntities
            {
                Abouts = aboutValues,
                Services = serviceValues,
                Contacts = contactValues,
                ServiceHeaders = serviceHeaderValues,
                Sliders = sliderValues
            };
            return View(viewModel);
        }
    }
}
