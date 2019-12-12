using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDomain
{
    public class Personel : BaseEntity
    {
        public int PersonelID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmanID { get; set; }
        public Departman Departman { get; set; }

    }
}
