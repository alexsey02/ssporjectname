using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSproject2.Domain.Entities;
using SSproject2.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace SSproject2.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;
        public EFTextFieldsRepository(AppDbContext context)//присвоение контекста базы данных
        {
            this.context = context;
        }
        void ITextFieldsRepository.DeleteTextFiled(Guid ID)//объявление метода удаления
        {
            context.TextFields.Remove(new TextFiled() { ID = ID });
            context.SaveChanges();
        }

        TextFiled ITextFieldsRepository.GetTextFiledByCodeWord(string codeWord)//объявление метода выборки по кодовому слову
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        TextFiled ITextFieldsRepository.GetTextFiledById(Guid ID)//объявление метода выборки по ШВ
        {
            return context.TextFields.FirstOrDefault(x => x.ID == ID);
        }

        IQueryable<TextFiled> ITextFieldsRepository.GetTextFileds()//объявление метода общей выборки
        {
            return context.TextFields;
        }

        void ITextFieldsRepository.SaveTextFiled(TextFiled entity)//объявление метода сохранения
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

        }
    }

}
