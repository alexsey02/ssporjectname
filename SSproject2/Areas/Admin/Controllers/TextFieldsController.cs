using Microsoft.AspNetCore.Mvc;
using SSproject2.Domain;
using SSproject2.Domain.Entities;
using SSproject2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;
        public TextFieldsController(DataManager dataManager)//объявление класса
        {
            this.dataManager = dataManager;
        }

        public IActionResult Edit(string codeWord)//объявление действия 
        {
            var entity = dataManager.TextFields.GetTextFiledByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextFiled model)//Создание представления для редактирования
        {
            if (ModelState.IsValid)
            {
                dataManager.TextFields.SaveTextFiled(model);
                return RedirectToAction(nameof (HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        public IActionResult Index()//Создание представления для возвращаемого элемента
        {
            return View();
        }
    }

}
