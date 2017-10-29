using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sem10.Entitities.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sem10.Repositories.Configurations.Maps
{
    class AutoMap:EntityTypeConfiguration<Auto>
    {
        public AutoMap()
        {

            ToTable("Auto");
            HasKey(o => o.Id);
            Property(o => o.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
