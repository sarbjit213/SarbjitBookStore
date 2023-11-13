using SarbjitsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace SarbjitsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {
        void Update(Category category);
    }
}
