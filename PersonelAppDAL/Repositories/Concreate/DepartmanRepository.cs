using PersonelAppDAL.Repositories.Abstract;
using PersonelAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDAL.Repositories.Concreate
{
    public class DepartmanRepository : Repository<Departman>, IDepartmanRepository
    {
        public DepartmanRepository(PersonelAppDbContext db) : base(db)
        {

        }
        public PersonelAppDbContext personelAppDb { get { return this._dbContext as PersonelAppDbContext; } }
        public Departman GetDepartmenByPersonel(Personel personel)
        {
            return personelAppDb.Departmens.Include("Personels").FirstOrDefault();
        }

        public IEnumerable<Departman> GetTopDepartment(int count)
        {
            return personelAppDb.Departmens.Take(count).ToList();
        }
    }
}
