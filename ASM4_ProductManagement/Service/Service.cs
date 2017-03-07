using ASM4_ProductManagement.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4_ProductManagement.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private Repository<TEntity> _repository;
        public Service()
        {
            _repository = new Repository<TEntity>( new NorthwindEntities());
        }
        public List<TEntity> GetAll()
        {
            return _repository.GetAll().ToList();
        }
    }
}
