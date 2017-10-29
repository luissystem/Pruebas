namespace Sem10.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Auto", "Estado", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Auto", "Estado", c => c.Boolean(nullable: false));
        }
    }
}
