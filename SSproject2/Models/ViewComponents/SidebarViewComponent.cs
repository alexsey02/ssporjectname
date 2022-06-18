using Microsoft.AspNetCore.Mvc;
using SSproject2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)//присвоение datamanager
        {
            this.dataManager = dataManager;
        }

        public Task<IViewComponentResult> InvokeAsync()//объявление метода выборки из общей структуры
        {
            return Task.FromResult((IViewComponentResult)View("Default", dataManager.PostItems.GetPostsItems()));
        }
    }
}
