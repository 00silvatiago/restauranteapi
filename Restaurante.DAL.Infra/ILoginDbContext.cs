﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Restaurante.Entities;

namespace Restaurante.DAL.Infra
{
    public interface ILoginDbContext : IDataBaseContext
    {
        IQueryable<Login> QueryLogin { get; }
        
    }
}
