using System.Web.Mvc;
using PetaPocoMVC_Sample.Models;

namespace PetaPocoMVC_Sample.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            var cm = new CustomerModel();
            ViewBag.Customers = cm.GetCustomers();
            return View();
        }

    }
}
