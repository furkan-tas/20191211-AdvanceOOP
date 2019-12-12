using PersonelAppDAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelAppDAL
{
    interface IUnitOfWork : IDisposable
    {
        IDepartmanRepository DepartmanRepository { get; }
        IPersonelRepository PersonelRepository { get; }
        int Complete();
    }
}
