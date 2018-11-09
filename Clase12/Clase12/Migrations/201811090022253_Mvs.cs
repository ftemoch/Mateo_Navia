namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mvs : DbMigration
    {
        public override void Up()
        {
			AddColumn("dbo.Movies", "IdTipoPelicula", c => c.Byte(nullable: false));
			AddColumn("dbo.Movies", "tipoPelicula_id", c => c.Byte());
			CreateIndex("dbo.Movies", "tipoPelicula_id");
			AddForeignKey("dbo.Movies", "tipoPelicula_id", "dbo.TipoPeliculas", "id");
		}
        
        public override void Down()
        {
			DropForeignKey("dbo.Movies", "tipoPelicula_id", "dbo.TipoPeliculas");
			DropIndex("dbo.Movies", new[] { "tipoPelicula_id" });
			DropColumn("dbo.Movies", "tipoPelicula_id");
			DropColumn("dbo.Movies", "IdTipoPelicula");
		}
    }
}
