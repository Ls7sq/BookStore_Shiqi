using BookStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly AppDbContext appDbContext;

        public HomeController(IBookRepository bookRepository, AppDbContext appDbContext)
        {
            this.bookRepository = bookRepository;
            this.appDbContext = appDbContext;
        }

        public ViewResult Index()
        {
            string sessionId = HttpContext.Request.Cookies["sessionId"];
            Session session = appDbContext.Sessions.FirstOrDefault(x => x.Id == sessionId);

            if (session != null)
            {
                ViewData["username"] = session.Customer.UserName.ToString();
            }

            ViewData["sessionId"] = HttpContext.Request.Cookies["sessionId"];
            var model = bookRepository.GetAllBook();
            return View(model);
        }

        [Authorize]
        public IActionResult Add()
        {
            return View();
        }
    }
}
