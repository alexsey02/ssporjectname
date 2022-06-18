using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

using SSproject2.Domain;
using SSproject2.Domain.Entities;
using SSproject2.Service;

using System;
using System.IO;

using Microsoft.AspNetCore.Http;

namespace SSproject2.Areas.OtdelSMI.Controllers
{
    [Area("OtdelSMI")]
    public class PostItemController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public PostItemController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new PostItem() : dataManager.PostItems.GetPostsItemById(id);
            return View(entity);
        }
        // file path: wwwroot/images
        [HttpPost]
        public IActionResult Edit(PostItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.PostItems.SavePostsItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.PostItems.DeletePostsItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
