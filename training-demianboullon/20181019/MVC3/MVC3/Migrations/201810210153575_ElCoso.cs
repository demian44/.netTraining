namespace MVC3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ElCoso : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ElCosoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ElCosoes");
        }
    }
}
