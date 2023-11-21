using SarbjitsBooks.DataAccess.Repository.IRepository;
using SarbjitsBooks.Models;
using SarbjitSBooks.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarbjitSBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
        Product GeT(int v);
    }
}
