using Microsoft.AspNetCore.Mvc;
using SSproject2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Areas.OtdelSMI.Controllers
{
    [Area("OtdelSMI")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)//объявление класса
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()//создание представления главной страницы
        {
            return View(dataManager.PostItems.GetPostsItems());
        }
        public IActionResult Index2()//возращает объект
        {
            return View();
        }
    }
}
