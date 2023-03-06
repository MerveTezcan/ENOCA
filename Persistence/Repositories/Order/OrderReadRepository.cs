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
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EnocaAPIDbContext context) : base(context)
        {
        }
    }
}
