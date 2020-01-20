using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data
{
    public class PrincipalContextFactory : IDesignTimeDbContextFactory<PrincipalContext>
    {
        public PrincipalContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PrincipalContext>();
            builder.UseNpgsql(
                @"Host=localHost;Database=Test;UserName=postgres;Password=zxcvbnm1A.",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(PrincipalContext)
                    .GetTypeInfo()
                    .Assembly
                    .GetName().Name)
                );
                return new PrincipalContext(builder.Options);
        }           
    }
}
