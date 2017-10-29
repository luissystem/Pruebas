using Sem10.Entitities.Models;
using Sem10.Repositories.Configurations.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem10.Repositories.Configurations
{
    public class DbEntities : DbContext
    {
        public virtual IDbSet<Producto> Productos { get; set; }
        public virtual IDbSet<Auto> Autos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ProductoMap());
            modelBuilder.Configurations.Add(new AutoMap());
        }
    }
}
