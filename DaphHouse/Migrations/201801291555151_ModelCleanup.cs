namespace DaphHouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelCleanup : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dogs", "DogName", c => c.String(nullable: false));
            AlterColumn("dbo.Dogs", "VetName", c => c.String(nullable: false));
            AlterColumn("dbo.Dogs", "VetPhone", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Dogs", "OwnerName", c => c.String(nullable: false));
            AlterColumn("dbo.Dogs", "OwnerPhone", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dogs", "OwnerPhone", c => c.String(maxLength: 10));
            AlterColumn("dbo.Dogs", "OwnerName", c => c.String());
            AlterColumn("dbo.Dogs", "VetPhone", c => c.String(maxLength: 10));
            AlterColumn("dbo.Dogs", "VetName", c => c.String());
            AlterColumn("dbo.Dogs", "DogName", c => c.String());
        }
    }
}
