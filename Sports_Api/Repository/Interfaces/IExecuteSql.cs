﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Repository
{
   public interface IExecuteSql<Tentity> 
    {
        IQueryable ExecuteSql(string sqlCommand);
    }
}
