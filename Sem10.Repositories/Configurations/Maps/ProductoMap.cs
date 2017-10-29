using Sem10.Entitities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem10.Repositories.Configurations.Maps
{
    public class ProductoMap: EntityTypeConfiguration<Producto>
    {
        public ProductoMap()
        {
            ToTable("Productos");
            HasKey(o => o.Id);
            Property(o => o.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
