using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSproject2.Domain.Entities;

namespace SSproject2.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository//объявление интерфейса страницы
    {
        IQueryable<TextFiled> GetTextFileds();
        TextFiled GetTextFiledById(Guid ID);
        TextFiled GetTextFiledByCodeWord(string codeWord);
        void SaveTextFiled(TextFiled entity);
        void DeleteTextFiled(Guid ID);
    }
}
