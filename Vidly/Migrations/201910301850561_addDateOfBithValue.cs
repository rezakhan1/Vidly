namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDateOfBithValue : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Customers(Name,isSubscribeToNewsLetter,MemberShipTypeId,DateOfBirth)  values('Antra',0,1,'10/12/2018')");
            Sql("Insert into Customers(Name,isSubscribeToNewsLetter,MemberShipTypeId,DateOfBirth)  values('Smith',2,2,'10/23/1994')");
            Sql("Insert into Customers(Name,isSubscribeToNewsLetter,MemberShipTypeId,DateOfBirth)  values('Pual',3,2,'12/12/1995') ");
            Sql("Insert into Customers(Name,isSubscribeToNewsLetter,MemberShipTypeId,DateOfBirth)  values('Josh',1,2,'23/12/1987') ");

        }

        public override void Down()
        {
        }
    }
}
