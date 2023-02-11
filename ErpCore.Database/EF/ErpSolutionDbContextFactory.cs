using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ErpCore.Database.EF
{
        public class ErpSolutionDbContextFactory : IDesignTimeDbContextFactory<ErpDbContext>
        {
            public ErpDbContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("ERPCoreDb");

                var optionsBuilder = new DbContextOptionsBuilder<ErpDbContext>();
                    optionsBuilder.UseSqlServer(connectionString);

                return new ErpDbContext(optionsBuilder.Options);
            }
        }
}
