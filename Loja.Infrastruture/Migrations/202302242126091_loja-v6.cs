namespace Loja.Infrastruture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lojav6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Test",
                c => new
                    {
                        TestID = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Test");
        }
    }
}
