namespace EntityFrameworkHonda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buldDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Civics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Trim = c.String(),
                        Doors = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Civics");
        }
    }
}
