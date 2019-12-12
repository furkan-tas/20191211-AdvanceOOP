using PersonelAppDAL.Repositories.Abstract;
using PersonelAppDAL.Repositories.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonelAppDbContext _db;
        public UnitOfWork(PersonelAppDbContext db)
        {
            _db = db;
            DepartmanRepository = new DepartmanRepository(_db);
            PersonelRepository = new PersonelRepository(_db);
        }
        public IDepartmanRepository DepartmanRepository { get;}
        public IPersonelRepository PersonelRepository { get;}

        public int Complete()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
