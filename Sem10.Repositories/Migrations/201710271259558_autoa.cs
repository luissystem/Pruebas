namespace Sem10.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class autoa : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Autoes", newName: "Auto");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Auto", newName: "Autoes");
        }
    }
}
