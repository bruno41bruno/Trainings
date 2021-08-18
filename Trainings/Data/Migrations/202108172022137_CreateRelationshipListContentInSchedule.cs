namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipListContentInSchedule : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "Schedule_Id", c => c.Int());
            CreateIndex("dbo.Contents", "Schedule_Id");
            AddForeignKey("dbo.Contents", "Schedule_Id", "dbo.Schedules", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Contents", new[] { "Schedule_Id" });
            DropColumn("dbo.Contents", "Schedule_Id");
        }
    }
}
