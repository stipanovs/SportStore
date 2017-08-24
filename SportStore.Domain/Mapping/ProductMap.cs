using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using FluentNHibernate.Mapping;using SportStore.Domain.Entities;

namespace SportStore.Domain.Mapping
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Products");
            Id(x => x.ProductID).Column("ProductID");
            Map(x => x.Name).Column("Name");
            Map(x => x.Description).Column("Description");
            Map(x => x.Category).Column("Category");
            Map(x => x.Price).Column("Price");
        }
    }
}
