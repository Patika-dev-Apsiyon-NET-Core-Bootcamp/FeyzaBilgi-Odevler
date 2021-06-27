using BookListApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListApp.Controllers
{
    public class BookController : Controller
    {        
        public IActionResult Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var result = BookViewModel.BookModels.Where(s => s.Name.Contains(searchString));
                return View(result.ToList());
            }
            return View(BookViewModel.BookModels);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(BookModel model)
        {
            BookViewModel.AddBookModel(model);
            return View(model);
        }       
        public IActionResult List()
        {    
            return View(BookViewModel.BookModels);
        }
    }
}
