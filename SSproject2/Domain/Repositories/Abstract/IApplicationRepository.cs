using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSproject2.Domain.Entities;

namespace SSproject2.Domain.Repositories.Abstract
{
    public interface IApplicationRepository//объявление интерфейса заявки
    {
        IQueryable<Application> GetApllications();
        Application GetApllicationById(Guid ID);
        void SaveApplication(Application entity);
      
    }
}
