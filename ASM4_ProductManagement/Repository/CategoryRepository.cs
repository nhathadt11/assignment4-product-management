using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Repository
{
    class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
