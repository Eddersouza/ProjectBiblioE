using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using ProjectBiblioE.Domain.Entities;
using ProjectBiblioE.Infra.Data.Map;
using System.Data.Entity.SqlServer;
using ProjectBiblioE.Infra.Data.Migrations;

namespace ProjectBiblioE.Infra.Data.EF
{
    /// <summary>
    /// Context to database.
    /// </summary>
    public class BiblioEContext : DbContext
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public BiblioEContext()
            : base("ProjectBiblioEDataSource")
        {
            var ensureDLLIsCopied = SqlProviderServices.Instance;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BiblioEContext, Configuration>("ProjectBiblioEDataSource"));

        }

        /// <summary>
        /// Instance of context languages.
        /// </summary>
        public DbSet<Language> Languages
        {
            get; set;
        }

        /// <summary>
        /// Method to create model.
        /// </summary>
        /// <param name="modelBuilder">Model to create.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new LanguageMap());
        }
    }
}