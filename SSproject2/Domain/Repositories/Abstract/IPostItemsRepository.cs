using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSproject2.Domain.Entities;

namespace SSproject2.Domain.Repositories.Abstract
{
    public interface IPostItemsRepository//объявление интерфейса поста
    {
        IQueryable<PostItem> GetPostsItems();
        PostItem GetPostsItemById(Guid ID);
        void SavePostsItem(PostItem entity);
        void DeletePostsItem(Guid ID);
    }
}
