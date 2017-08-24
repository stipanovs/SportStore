using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using SportStore.Domain.Entities;

namespace SportStore.Domain.Concrete
{
    public class NHibernateProvider
    {
        private const string connString = @"Server=.;Database=SportsStore;Trusted_Connection=True";


        private static ISessionFactory _sessionFactory;

        public static ISession GetSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = CreateSessionFactory();
            }
            return _sessionFactory.OpenSession();
        }
        private static ISessionFactory CreateSessionFactory()
        {

            return Fluently.Configure()
                .Database(MsSqlConfiguration
                .MsSql2012
                .ConnectionString(connString))
                .Mappings(m => m.FluentMappings
                .AddFromAssemblyOf<Product>())
                //.ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                .BuildSessionFactory();
        }
    }
}
