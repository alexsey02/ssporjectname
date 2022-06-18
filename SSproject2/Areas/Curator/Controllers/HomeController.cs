using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

using SSproject2.Domain;
using SSproject2.Domain.Entities;
using SSproject2.Service;

using System;
using System.IO;

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data;
using OfficeOpenXml;

namespace SSproject2.Areas.Curator.Controllers
{
    [Area("Curator")]
    public class HomeController : Controller
    {
        private AppDbContext db;
        Db DBB = new Db();

        public HomeController(AppDbContext context)//объявление класса
        {
            db = context;
        }
        
        public async Task<IActionResult> Index()//создание представления главной страницы
        {
            DataSet ds = DBB.dataSet();
            return View(await db.Applications.ToListAsync());
            
        }

        public IActionResult ExportApp()
        {
            DataSet ds = DBB.dataSet();
            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets.Add("Заявки");
                worksheet.Cells.LoadFromDataTable(ds.Tables[0], true);
                package.Save();
            }
            stream.Position = 0;
            string excel = $"Лист с заявками-{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excel);
        }

        public IActionResult Index2()//возращает объект
        {
            return View();
        }

    }
}
