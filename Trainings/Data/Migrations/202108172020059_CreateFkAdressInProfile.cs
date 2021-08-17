namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFkAdressInProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Address_Id", c => c.Int());
            CreateIndex("dbo.Profiles", "Address_Id");
            AddForeignKey("dbo.Profiles", "Address_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Profiles", new[] { "Address_Id" });
            DropColumn("dbo.Profiles", "Address_Id");
        }
    }
}
