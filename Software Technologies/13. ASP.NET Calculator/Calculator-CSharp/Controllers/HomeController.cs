using System.Web.Mvc;
using Calculator_CSharp.Models;

namespace Calculator_CSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

	    [HttpPost]
	    public ActionResult Calculate(Calculator calculator)
	    {
		    calculator.Result = calculator.CalculateResult();

		    return RedirectToAction("Index", calculator);
	    }
    }
}