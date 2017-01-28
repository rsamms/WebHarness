using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebHarness.Domain.Entities;

namespace WebHarness.Domain.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public DataContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, DataMigrationsConfiguration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add<PluralizingTableNameConvention>();
        }
    }
}
