using ASM4_ProductManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Service
{
    public class SuppilerService : Service<Supplier>, ISuppilerService
    {
        private SuppilerRepository _suppilerRepository;
        public SuppilerService()
        {
            _suppilerRepository = new SuppilerRepository(new NorthwindEntities());
        }
        public List<Supplier> SearchSuppilerByCompanyName(string name)
        {
            return _suppilerRepository.Find(s => s.CompanyName.Contains(name))
                                      .ToList();
        }
    }
}
