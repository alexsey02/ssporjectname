using Microsoft.AspNetCore.Mvc;
using SSproject2.Domain;
using SSproject2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Controllers
{
    public class PostController : Controller
    {
        private readonly DataManager dataManager;

        public PostController(DataManager dataManager)//объявление класса
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)//объявление выбора поста по ID
        {
            if (id != default)
            {
                return View("Show", dataManager.PostItems.GetPostsItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFiledByCodeWord("PagePosts");
            return View(dataManager.PostItems.GetPostsItems());
        }
        [HttpPost]
        public IActionResult Delete(Guid id)//объявление удаления поста из sidebar
        {
            dataManager.PostItems.DeletePostsItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
