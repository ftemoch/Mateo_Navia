namespace ParcialFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datosLibro : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO TipoLibroes(Id,Nombre) VALUES (1,'Literatura')");
			Sql("INSERT INTO TipoLibroes(Id,Nombre) VALUES (2,'Cientifico')");
			Sql("INSERT INTO TipoLibroes(Id,Nombre) VALUES (3,'Biografias')");
			Sql("INSERT INTO TipoLibroes(Id,Nombre) VALUES (4,'Monografias')");
		}
        
        public override void Down()
        {
        }
    }
}
