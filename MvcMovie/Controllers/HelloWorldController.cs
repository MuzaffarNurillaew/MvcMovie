using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Text;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            string msg = "Hello world this is index page!\n";
            return View("index", msg);
        }
        //[HttpGet("[controller]/welcomePage")]
        public IActionResult Welcome(string name, int loopcount = 1)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < loopcount; i++)
            {
                sb.Append($"Hello {name}\n");
            }
            return View("Welcome", sb.ToString());
        }
    }
}
