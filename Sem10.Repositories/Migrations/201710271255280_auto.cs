namespace Sem10.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Año = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Color = c.String(),
                        Precio = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Precio = c.Double(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productos");
            DropTable("dbo.Autoes");
        }
    }
}
