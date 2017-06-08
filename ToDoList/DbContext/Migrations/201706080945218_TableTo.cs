namespace DbContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableTo : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.TodoLists",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    Title = c.String(),
                    Description = c.String(),
                    DateAdded = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.id);
        }
        
        public override void Down()
        {
            DropTable("dbo.TodoLists");
        }
    }
}
