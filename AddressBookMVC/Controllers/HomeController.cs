using Microsoft.AspNet.Mvc;
using ViewModels.Models;

namespace AddressBookMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AddressToAddVM address = new AddressToAddVM();
            address.address = new Address();
            address.CreateStateList();

            return View(address);
        }

        [HttpPost]
        public ActionResult AddAddress(AddressToAddVM newAddress)
        {
            return View("Result", newAddress.address);
        }
    }
}
