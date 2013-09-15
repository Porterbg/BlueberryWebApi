using MathFightWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFightWebApi.Data.Mappins
{
    public class ProblemMap : EntityTypeConfiguration<Problem>
    {
        public ProblemMap()
        {
            this.HasKey(p => p.Id);

            this.Property(p => p.Qestion).IsRequired();

            this.Property(p => p.Answer).IsRequired();

            this.Property(p => p.Difficulty).IsRequired();
        }
    }
}
