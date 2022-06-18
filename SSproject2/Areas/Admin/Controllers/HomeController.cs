using Microsoft.AspNetCore.Mvc;
using SSproject2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)//создание класса контроллера
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()//Создание представления для вывода всех постов
        {
            return View(dataManager.PostItems.GetPostsItems());
        }
        public IActionResult Index2()//СОздание представления для возвращаемого элемента
        {
            return View();
        }
    }
}
