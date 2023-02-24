using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        void Rollback();

        void Commit();
    }
}
