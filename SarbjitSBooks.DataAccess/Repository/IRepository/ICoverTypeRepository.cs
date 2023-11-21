using SarbjitsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SarbjitsBooks.DataAccess.Repository.IRepository;

namespace SarbjitSBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository :IRepository<CoverType>
    {
        void Update(CoverType covertype);
    }
}
