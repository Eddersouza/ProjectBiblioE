namespace ProjectBiblioE.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Int(nullable: false, identity: true),
                        CultureCode = c.String(nullable: false, maxLength: 8, unicode: false),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.LanguageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Languages");
        }
    }
}
