using System.Web.Mvc;
using PerpetuumSoft.Knockout;
using WebDemo.Models;

namespace WebDemo.Controllers
{

    public class HomeController : KnockoutController
    {

        public ViewResult KnockoutJs()
        {
            ContactData starterContact = getContactSeed();

            return View(starterContact);
        }

        private ContactData getContactSeed()
        {
            var seed = new ContactData();
            seed.LastName = "Johanssen";
            seed.FirstName = "Scarlett";
            return seed;
        }

        public ViewResult KnockoutMvc()
        {
            ContactData starterContact = getContactSeed();

            return View(starterContact);
        }

        public ViewResult KnockoutWebApi()
        {

            ContactData starterContact = getContactSeed();
            Contact starter = new Contact
            {
                Name = new Name
                {
                    FirstName = "Scarlett",
                    LastName = "Johanssen"
                },
                Address = new Address()
                {
                    City = "Fruitport",
                    State = "MI",
                    Street = "2102 Gateway Dr."
                }
            };

            return View(starter);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}