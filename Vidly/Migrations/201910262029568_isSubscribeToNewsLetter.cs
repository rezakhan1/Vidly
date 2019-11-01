namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isSubscribeToNewsLetter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isSubscribeToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "isSubscribeToNewsLetter");
        }
    }
}
