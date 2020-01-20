using Business;
using Data.Maps;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class PrincipalContext : DbContext
    {
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Qualifications> Qualifications { get; set; }
        public PrincipalContext(DbContextOptions<PrincipalContext>options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SkillMap());
            modelBuilder.ApplyConfiguration(new QualificationMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
