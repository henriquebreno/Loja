using Loja.Domain.DAO;
using Loja.Domain.Interfaces;
using Loja.Infrastruture.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infrastruture
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        public TestRepository(Context context) : base(context)
        {
        }
    }
}
