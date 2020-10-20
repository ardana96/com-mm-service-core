using Com.Moonlay.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Com.MM.Service.Core.Lib.Models;
using Com.MM.Service.Core.Lib.Models.Account_and_Roles;
using System.Linq;
using Com.MM.Service.Core.Lib.Models.Module;

namespace Com.MM.Service.Core.Lib
{
    public class CoreDbContext : BaseDbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {
        }


        
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<ArticleCollection> ArticleCollections { get; set; }
        public DbSet<ArticleColor> ArticleColors { get; set; }
        public DbSet<ArticleCounter> ArticleCounters { get; set; }
        public DbSet<ArticleMaterial> ArticleMaterials { get; set; }
        public DbSet<ArticleMaterialComposition> ArticleMaterialCompositions { get; set; }
        public DbSet<ArticleMotif> ArticleMotifs { get; set; }
        public DbSet<ArticleProces> ArticleProcess { get; set; }
        public DbSet<ArticleSeason> ArticleSeasons { get; set; }
        public DbSet<ArticleSize> ArticleSizes { get; set; }
        public DbSet<ArticleSubCollection> ArticleSubCollections { get; set; }
        public DbSet<ArticleSubCounter> ArticleSubCounters { get; set; }
        public DbSet<ArticleSubProces> ArticleSubProcess { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<AccountProfile> AccountProfiles { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleDestination> ModuleDesstinations { get; set; }
        public DbSet<ModuleSource> ModuleSources { get; set; }
        public DbSet<Expedition> Expeditions { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Bank>Banks { get; set; }
        public DbSet<CardType> CardTypes { get; set; }

        public DbSet<Unit> Units { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Item>()
                .Ignore(c => c.ImgFile);

           
        }
    }
}
