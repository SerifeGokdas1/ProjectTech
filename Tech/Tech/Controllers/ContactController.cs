using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Tech.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EFContactRepository());
        AboutManager aboutManager = new AboutManager(new EFAboutRepository());
        ServiceManager serviceManager = new ServiceManager(new EFServiceRepository());
        ContactMailManager contactMailManager = new ContactMailManager(new EFContactMailRepository());
        [HttpGet]
        public IActionResult Index()
        {
            var contactValues = contactManager.GetListAll();
            var aboutValues = aboutManager.GetListAll();
            var serviceValues = serviceManager.GetListAll();

            var viewModel = new AllEntities
            {
                Contacts = contactValues,
                Abouts = aboutValues,
                Services = serviceValues
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(ContactMail contactMail)
        {
            contactMail.ContactMailDate = DateTime.Now.ToString();
            contactMail.ContactMailStatus = true;
            if (ModelState.IsValid)
            {
                //contactMail.ContactMailDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                
                try
                {
                    contactMailManager.TAdd(contactMail);
                }
                catch (Exception ex)
                {
                    var message = ex;
                }

                return RedirectToAction("Index");
            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors)
                                       .Select(e => e.ErrorMessage)
                                       .ToList();

                var message = errors;
                return RedirectToAction("Index");
            }

        }
    }
}
