using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Concrete
{
    public class NhProductRepository : IProductRepository
    {
        private readonly ISession _session = null;

        public NhProductRepository()
        {
            _session = NHibernateProvider.GetSession();
        }
        public IEnumerable<Product> Products => _session.QueryOver<Product>().List<Product>();
    }
}
