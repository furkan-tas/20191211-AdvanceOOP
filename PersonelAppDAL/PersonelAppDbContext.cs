using PersonelAppDomain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDAL
{
    public class PersonelAppDbContext : DbContext
    {
        public PersonelAppDbContext() : base("Server = . ; Database = PersonelApp ; uid = sa; pwd = 123")
        {

        }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Departman> Departmens { get; set; }        
    }

}
