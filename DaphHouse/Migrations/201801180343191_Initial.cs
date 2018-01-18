namespace DaphHouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Dogs",
                c => new
                   {
                        DogID = c.Int(nullable: false, identity: true),
                        DogName = c.String(),
                        Breed = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        VetName = c.String(),
                        VetPhone = c.String(maxLength: 8),
                        OwnerName = c.String(),
                        OwnerPhone = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.DogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dogs");
        }
    }
}
