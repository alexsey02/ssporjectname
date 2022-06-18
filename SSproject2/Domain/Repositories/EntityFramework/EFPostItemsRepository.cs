using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SSproject2.Domain.Entities;
using SSproject2.Domain.Repositories.Abstract;

namespace SSproject2.Domain.Repositories.EntityFramework
{
    public class EFPostItemsRepository : IPostItemsRepository
    {
        private readonly AppDbContext context;
        public EFPostItemsRepository(AppDbContext context)//присвоение контекста базы данных
        {
            this.context = context;
        }

        public void DeletePostsItem(Guid ID)//объявление метода удаления из БД
        {
            context.PostItems.Remove(new PostItem() { ID = ID });
            context.SaveChanges();
        }

        public PostItem GetPostsItemById(Guid ID)//объявление метода нахождения по ID
        {
            return context.PostItems.FirstOrDefault(x => x.ID == ID);

        }

        public IQueryable<PostItem> GetPostsItems()//Объявление метода общей выборки
        {
            return context.PostItems;
        }

        public void SavePostsItem(PostItem entity)//Объявение метода сохранения
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
