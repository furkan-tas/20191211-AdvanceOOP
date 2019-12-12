using PersonelAppDAL.Repositories.Abstract;
using PersonelAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDAL.Repositories.Concreate
{
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {
        public PersonelRepository(PersonelAppDbContext db) : base(db)
        {

        }
        public PersonelAppDbContext PersonelAppDbContext { get { return this._dbContext as PersonelAppDbContext; } }
        public IEnumerable<Personel> GetPersonelsByDepartman(Departman departman)
        {
            return PersonelAppDbContext.Personels.Include("Departman").ToList();
        }

    }
}
