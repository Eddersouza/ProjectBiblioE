namespace ProjectBiblioE.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;

    using EF;

    internal sealed class Configuration : DbMigrationsConfiguration<BiblioEContext>
    {
        private readonly bool _pendingMigrations;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            // Check if there are migrations pending to run, this can happen if database doesn't exists or if there was any
            //  change in the schema

            var migrator = new DbMigrator(this);
            _pendingMigrations = migrator.GetPendingMigrations().Any();

            // If there are pending migrations run migrator.Update() to create/update the database then run the Seed() method to populate
            //  the data if necessary
            if (_pendingMigrations)
            {
                migrator.Update();
                Seed(new BiblioEContext());
            }
        }

        protected override void Seed(BiblioEContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}