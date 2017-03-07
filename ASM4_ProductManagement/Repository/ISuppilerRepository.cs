using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Repository
{
    interface ISuppilerRepository : IRepository<Supplier>
    {
        IEnumerable<Supplier> GetSuppliersByCompanyName(string companyName);
    }
}
