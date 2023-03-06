﻿using ENOCA.APPLICATION.Repositories;
using ENOCA.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENOCA.APPLICATION.Repositories
{
    public interface IOrderWriteRepository : IWriteRepository<Order>
    {
    }
}
