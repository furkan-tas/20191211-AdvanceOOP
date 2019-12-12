using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDomain
{
    public class Departman : BaseEntity
    {
        public Departman()
        {
            Personels = new HashSet<Personel>();
        }
        public int DepartmanID { get; set; }
        public string Name { get; set; }
        
        public ICollection<Personel> Personels { get; set; }

    }
}
