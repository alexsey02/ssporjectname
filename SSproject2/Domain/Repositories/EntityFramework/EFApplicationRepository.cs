using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SSproject2.Domain.Entities;
using SSproject2.Domain.Repositories.Abstract;

namespace SSproject2.Domain.Repositories.EntityFramework
{
    public class EFApplicationRepository : IApplicationRepository
    {
        private readonly AppDbContext context;

        public EFApplicationRepository(AppDbContext context)//объявлеие метода показа заявок
        {
            this.context = context;
        }

        public Application GetApllicationById(Guid ID)//объявление метода выборки заявок по ID
        {
            return context.Applications.FirstOrDefault(x => x.ID == ID);

        }

        public IQueryable<Application> GetApllications()//объявление показа заявок
        {
            return context.Applications;
        }
        public void SaveApplication(Application entity)//объявление метода сохранения заявок
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
