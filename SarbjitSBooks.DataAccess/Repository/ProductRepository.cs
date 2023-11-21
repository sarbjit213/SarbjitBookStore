using SarbjitBookStore.DataAccess.Data;
using SarbjitsBooks.DataAccess.Repository;
using SarbjitsBooks.Models;
using SarbjitSBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarbjitSBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Product GeT(int v)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                    // _db.SaveChanges();

                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;

            }

        }
    }
}
