using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebUI.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        protected DatabaseContext db;

        public UserController (DatabaseContext _db){
    db =_db;
        }

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Query based syntax
            var q= (from u in db.Users select u).ToList();

            
            //Method based syntax
            // var qq = db.Users.Select(u=>u).ToList();

            return View(q);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}