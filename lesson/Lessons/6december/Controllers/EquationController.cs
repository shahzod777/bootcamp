using _6december.Models;
using Microsoft.AspNetCore.Mvc;

namespace _6december.Controllers
{
    public class EquationController : Controller
    {
        public ActionResult Promise()
        {
            return View();
        }        
        [HttpPost]
        public ActionResult Promise(Solve equation)
        {
            equation.Calculate();
            return View(equation);
        }
    }
}