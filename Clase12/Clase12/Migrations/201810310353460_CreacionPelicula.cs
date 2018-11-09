namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionPelicula : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoPeliculas",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        Nombre = c.String(),
                        costoDia = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.id);           
       
        }
        
        public override void Down()
        {            
            DropTable("dbo.TipoPeliculas");
        }
    }
}
