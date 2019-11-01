namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMovieInMovieTbl : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies(Name,Genre)  values('HangOver','Comedy')");
            Sql("Insert into Movies(Name,Genre)  values('DieHard','Action')");
            Sql("Insert into Movies(Name,Genre)  values('Toy Story','Family') ");
            Sql("Insert into Movies(Name,Genre)  values('The Terminator','Action') ");
            Sql("Insert into Movies(Name,Genre)  values('Titanic','Rpmance') ");

        }

        public override void Down()
        {
        }
    }
}
