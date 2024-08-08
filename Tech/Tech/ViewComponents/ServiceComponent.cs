using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Tech.ViewComponents
{
    public class ServiceComponent : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager (new EFServiceRepository());
        ServiceHeaderManager serviceHeaderManager = new ServiceHeaderManager(new EFServiceHeaderRepository());

        public IViewComponentResult Invoke()
        {
            var serviceValue = serviceManager.GetListAll();
            var serviceHeaderValue = serviceHeaderManager.GetListAll();
            var serviceValues = new AllEntities()
            {
                Services = serviceValue,
                ServiceHeaders = serviceHeaderValue
            };

            return View(serviceValues);
        }
    }
}
