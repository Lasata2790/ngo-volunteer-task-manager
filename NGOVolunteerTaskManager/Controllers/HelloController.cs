using Microsoft.AspNetCore.Mvc;

namespace NGOVolunteerTaskManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        public string Get()
        {
            return "NGO Volunteer Task Manager - Day 1 started!";
        }
    }
}
