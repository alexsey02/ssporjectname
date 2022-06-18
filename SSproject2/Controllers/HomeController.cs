using Microsoft.AspNetCore.Mvc;
using SSproject2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        
        public HomeController(DataManager dataManager)//объявление класса
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()//объявление действия показа главной страницы
        {
            return View(dataManager.TextFields.GetTextFiledByCodeWord("PageIndex"));
        }
        public IActionResult Contacts()//объявление действия показа старанцы контакты
        {
            return View(dataManager.TextFields.GetTextFiledByCodeWord("PageContacts"));
        }
        public IActionResult Admin()//объявление показа страницы административной зоны
        {
            return View();
        }
    }
}
