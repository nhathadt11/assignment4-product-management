using ASM4_ProductManagement.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        private ProductRepository _productRepository;
        public ProductService()
        {
            _productRepository = new ProductRepository(new NorthwindEntities());
        }

        public List<Product> SearchProductByName(string name)
        {
            return _productRepository.Find(p => p.ProductName.Contains(name))
                                     .ToList();
        }
    }
}
