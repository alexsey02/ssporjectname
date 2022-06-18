using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

using SSproject2.Domain;
using SSproject2.Domain.Entities;
using SSproject2.Service;

using System;
using System.IO;

using Microsoft.AspNetCore.Http;
using System.Data;
using OfficeOpenXml;
using System.Threading.Tasks;

namespace SSproject2.Areas.Curator.Controllers
{
    [Area("Curator")]
    public class ApllicationController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly MailClass mailClass;
        private readonly AppDbContext _dbContext;
     

        public ApllicationController(DataManager dataManager, IWebHostEnvironment hostingEnvironment,MailClass mailClass, AppDbContext dbContext)//объявление класса
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
            _dbContext = dbContext;
            this.mailClass = mailClass;
        }

        public IActionResult Edit(Guid id)////объявление действия 
        {
            var entity = id == default ? new Application() : dataManager.Applications.GetApllicationById(id);
            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(Application model)//Создание представления для редактирования
        {
            if (ModelState.IsValid && model.AppStatus.Contains("Passed"))
            {
                dataManager.Applications.SaveApplication(model);
                MailClass mailClass = new MailClass();
                await mailClass.SendEmail(model.mail, "Статус", "Данная заявка одобрена,приходите в кабинет 119");
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

       
        public IActionResult Index()//Создание представления для возвращаемого элемента
        {
            
            return View();
        }
    }
}
