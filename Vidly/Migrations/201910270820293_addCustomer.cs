namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Customers(Name,isSubscribeToNewsLetter,MemberShipTypeId)  values('Reza',0,1)");
            Sql("Insert into Customers(Name,isSubscribeToNewsLetter,MemberShipTypeId)  values('Hanjala',1,1)");
            Sql("Insert into Customers(Name,isSubscribeToNewsLetter,MemberShipTypeId)  values('Azhar',1,2) ");
            Sql("Insert into Customers(Name,isSubscribeToNewsLetter,MemberShipTypeId)  values('John',1,1) ");

        }

        public override void Down()
        {
        }
    }
}
