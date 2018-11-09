namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatosTipoPelicula : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO TipoPeliculas(Id,Nombre,costoDia) VALUES (1,'Terror',50)");
			Sql("INSERT INTO TipoPeliculas(Id,Nombre,costoDia) VALUES (2,'Comedia',100)");
			Sql("INSERT INTO TipoPeliculas(Id,Nombre,costoDia) VALUES (3,'Accion',300)");
		}
        
        public override void Down()
        {
        }
    }
}
