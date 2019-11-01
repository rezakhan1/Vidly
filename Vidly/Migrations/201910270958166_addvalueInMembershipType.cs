namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvalueInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update MemberShipTypes set MemberShipType='Pay Per Go'  where Id=1");
            Sql("update MemberShipTypes set MemberShipType='Monthly'   where Id=2");
            Sql("update MemberShipTypes set MemberShipType='Quaterly'  where Id=3");
            Sql("update MemberShipTypes set MemberShipType='Yearly'  where Id=4");
           
        }

        public override void Down()
        {
        }
    }
}
