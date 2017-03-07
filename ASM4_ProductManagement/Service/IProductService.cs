using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Service
{
    interface IProductService : IService<Product>
    {
        List<Product> SearchProductByName(string name);
    }
}
