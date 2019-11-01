namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMemberShipTypeCoulmn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "MembershipType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "MembershipType");
        }
    }
}
