namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MemberShipTypes(Id,SingupFee,DurationInMonth,DiscoutRate) values(1,0,0,0) ");
            Sql("Insert into MemberShipTypes(Id,SingupFee,DurationInMonth,DiscoutRate) values(2,30,1,10) ");
            Sql("Insert into MemberShipTypes(Id,SingupFee,DurationInMonth,DiscoutRate) values(3,90,3,15) ");
            Sql("Insert into MemberShipTypes(Id,SingupFee,DurationInMonth,DiscoutRate) values(4,300,12,20) ");
        }
        
        public override void Down()
        {
        }
    }
}
