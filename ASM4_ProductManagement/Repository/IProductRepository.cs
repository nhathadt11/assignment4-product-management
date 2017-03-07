using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Repository
{
    interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductByName(string name);
    }
}
