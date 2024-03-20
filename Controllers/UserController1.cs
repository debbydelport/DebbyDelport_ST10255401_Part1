using Microsoft.AspNetCore.Mvc;
using TEST101.Models;
namespace TEST101.Controllers
{
    public class UserController1 : Controller
    {

        public Table_1 usertbl = new Table_1();

        [HttpPost]
        public ActionResult About(Table_1 usertbl)
        {
            var result = usertbl.insert_User(usertbl);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(usertbl);
        }

    }
}
