using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        IEnumerable<Product> IProductRepository.GetProductByName(string name)
        {
            return Context.Set<Product>()
                          .Where(p => p.ProductName.Contains(name));
        }
    }
}
