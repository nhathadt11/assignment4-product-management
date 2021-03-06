﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Service
{
    interface IService<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
    }
}
