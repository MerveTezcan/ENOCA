using ENOCA.APPLICATION.Repositories;
using ENOCA.DOMAIN.Entities;
using ENOCA.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENOCA.Persistence.Repositories
{
    internal class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EnocaAPIDbContext context) : base(context)
        {
        }
    }
}
