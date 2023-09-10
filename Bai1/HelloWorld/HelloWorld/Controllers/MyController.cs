using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    [Route("MyRoute")]
    public class MyController : Controller
    {
        private const string MYVIEW = "MyView";

        public IActionResult Index(string message, int page, int? id)
        {
            if(id != null)
                ViewBag.Id = id;
            ViewBag.Message = message;
            ViewBag.Date = DateTime.Now;
            ViewBag.Page = page;
            Message m = new Message(message, page);
            return View(m);
        }

        [HttpGet("MyAction/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("MyAction/Add")]
        public IActionResult Add(Message m, int id = 0) {
            ViewBag.Id = id;
            ViewBag.Message = m.msg;
            ViewBag.Date = DateTime.Now;
            ViewBag.Page = m.pgnum;
            return View(MYVIEW);
        }

    }
}
