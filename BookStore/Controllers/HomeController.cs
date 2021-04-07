using BookStore.Models;
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

        public HomeController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public ViewResult Index()
        {
            var model = bookRepository.GetAllBook();
            return View(model);
        }
    }
}
