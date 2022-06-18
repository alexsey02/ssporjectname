using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSproject2.Domain.Repositories.Abstract;

namespace SSproject2.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IPostItemsRepository PostItems { get; set; }
        public IApplicationRepository Applications { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IPostItemsRepository postItemsRepository, IApplicationRepository applicationRepository )//объявление класса DATAmANAGER
        {
            TextFields = textFieldsRepository;
            PostItems = postItemsRepository;
            Applications = applicationRepository;                           

        }       
    }
}
