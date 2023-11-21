using SarbjitBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SarbjitsBooks.Models;
using SarbjitsBooks.DataAccess.Repository.IRepository;
using SarbjitSBooks.DataAccess.Repository.IRepository;
using SarbjitsBooks.DataAccess.Repository;

namespace SarbjitSBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {

        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;
                // _db.SaveChanges();
            }
        }

    }
}
