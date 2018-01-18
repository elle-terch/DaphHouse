namespace DaphHouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringLength2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dogs", "VetPhone", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Dogs", "VetPhone", c => c.String(maxLength: 18));
        }
    }
}
