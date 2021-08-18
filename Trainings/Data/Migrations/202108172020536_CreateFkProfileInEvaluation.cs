namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateFkProfileInEvaluation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Evaluations", "Profile_Id", c => c.Int());
            CreateIndex("dbo.Evaluations", "Profile_Id");
            AddForeignKey("dbo.Evaluations", "Profile_Id", "dbo.Profiles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evaluations", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.Evaluations", new[] { "Profile_Id" });
            DropColumn("dbo.Evaluations", "Profile_Id");
        }
    }
}
