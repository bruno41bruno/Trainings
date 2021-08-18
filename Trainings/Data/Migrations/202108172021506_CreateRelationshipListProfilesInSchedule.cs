namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipListProfilesInSchedule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Schedule_Id", c => c.Int());
            CreateIndex("dbo.Profiles", "Schedule_Id");
            AddForeignKey("dbo.Profiles", "Schedule_Id", "dbo.Schedules", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Profiles", new[] { "Schedule_Id" });
            DropColumn("dbo.Profiles", "Schedule_Id");
        }
    }
}
