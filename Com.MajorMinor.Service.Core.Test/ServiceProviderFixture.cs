using Com.MM.Service.Core.Lib;
using Com.MM.Service.Core.Lib.Services;
using Com.MM.Service.Core.Test.DataUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Xunit;

namespace Com.MM.Service.Core.Test
{
    public class ServiceProviderFixture : IDisposable
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public ServiceProviderFixture()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("Secret", "DANLIRISTESTENVIRONMENT"),
					new KeyValuePair<string, string>("ASPNETCORE_ENVIRONMENT", "Test"),
                    new KeyValuePair<string, string>("DefaultConnection",  "Server=localhost,1401; Database = com.danliris.db.core.service.test; User = sa; password = Standar123.; MultipleActiveResultSets = true; ")
                    //new KeyValuePair<string, string>("DefaultConnection", "Server=(localdb)\\mssqllocaldb;Database=com-danliris-db-test;Trusted_Connection=True;MultipleActiveResultSets=true"),
                   
                })
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection") ?? configuration["DefaultConnection"];

            this.ServiceProvider = new ServiceCollection()
                .AddDbContext<CoreDbContext>((serviceProvider, options) =>
                {
                    options.UseSqlServer(connectionString);
                }, ServiceLifetime.Transient)
                .AddTransient<UnitService>(provider => new UnitService(provider))
                .AddTransient<UnitDataUtil>()
              
            
             
                
        
       
                .AddTransient<DivisionService>(provider => new DivisionService(provider))
                .AddTransient<DivisionDataUtil>()
             
             
             
          
                .AddTransient<UnitService>(provider => new UnitService(provider))
		
		
               
              
                .AddTransient<AccountRoleDataUtil>()
                .AddTransient<PermissionDataUtil>()
   
                .AddTransient(provider => new ArticleCategoryService(provider))
             

                .BuildServiceProvider();

            CoreDbContext dbContext = ServiceProvider.GetService<CoreDbContext>();
            dbContext.Database.Migrate();
        }

        public void Dispose()
        {
        }
    }

    [CollectionDefinition("ServiceProviderFixture Collection")]
    public class ServiceProviderFixtureCollection : ICollectionFixture<ServiceProviderFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}