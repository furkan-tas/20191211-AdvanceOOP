using PersonelAppDAL.Abstract;
using PersonelAppDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDAL.Repositories.Abstract
{
    public interface IPersonelRepository : IRepository<Personel>
    {
        IEnumerable<Personel> GetPersonelsByDepartman(Departman departman);

    }
}
