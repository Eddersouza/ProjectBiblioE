namespace ProjectBiblioE.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        CultureCode = c.String(nullable: false, maxLength: 8, unicode: false),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.CultureCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Languages");
        }
    }
}
