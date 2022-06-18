using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSproject2.Domain;
using SSproject2.Domain.Entities;
using SSproject2.Domain.Repositories.EntityFramework;
using System.Timers;
namespace SSproject2.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly MailClass mailClass;
        private readonly AppDbContext _dbContext;
        public ApplicationController(MailClass mailClass, AppDbContext dbContext)//объявление класса
        {
            this.mailClass = mailClass;
            _dbContext = dbContext;
           
        }
        [HttpGet]
        public IActionResult Index()//объявление стартовой странцы
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string email, string boxAp)//обработка метода подачи заявки
        {
            if(email != null && email.Contains("@mpt.ru")   && boxAp != null)
            {
                Random rnd = new Random();
                int value = rnd.Next();
                _dbContext.Applications.Add(new Application { AppText = boxAp, mail = email, AppStatus = "active", AppNumber = value });
                await _dbContext.SaveChangesAsync();
                MailClass mailClass = new MailClass();
                await mailClass.SendEmail(email, "Статус", "Данная заявка принята к рассмотрению,ожидайте решения через сутки");
                return RedirectToAction("Index");
            }
            else
            {

                return RedirectToAction("Error");
            }
        }
        [HttpGet]
        public IActionResult Error()//вызов метода ошибки
        {
            return View();
        }
        public IActionResult action()//Переадресация на действие после ошибки
        {
            return View("Index");
        }




    }
}
