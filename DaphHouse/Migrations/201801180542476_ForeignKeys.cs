namespace DaphHouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visits",
                c => new
                    {
                        VisitID = c.Int(nullable: false, identity: true),
                        DayIn = c.DateTime(nullable: false),
                        DayOut = c.DateTime(nullable: false),
                        RoomType = c.Int(nullable: false),
                        DogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VisitID)
                .ForeignKey("dbo.Dogs", t => t.DogID, cascadeDelete: true)
                .Index(t => t.DogID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visits", "DogID", "dbo.Dogs");
            DropIndex("dbo.Visits", new[] { "DogID" });
            DropTable("dbo.Visits");
        }
    }
}
