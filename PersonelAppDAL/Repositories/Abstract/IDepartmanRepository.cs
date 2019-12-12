using PersonelAppDAL.Abstract;
using PersonelAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDAL.Repositories.Abstract
{
    public interface IDepartmanRepository : IRepository<Departman>
    {
        IEnumerable<Departman> GetTopDepartment(int count);
        Departman GetDepartmenByPersonel(Personel personel);

    }
}
