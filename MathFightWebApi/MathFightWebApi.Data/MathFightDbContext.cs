using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathFightWebApi.Models;
using MathFightWebApi.Data.Mappins;

namespace MathFightWebApi.Data
{
    public class MathFightDbContext : DbContext
    {
        public MathFightDbContext()
            : base("MathFightDb")
        {
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Problem> Problems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProblemMap());
            modelBuilder.Configurations.Add(new UserMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
