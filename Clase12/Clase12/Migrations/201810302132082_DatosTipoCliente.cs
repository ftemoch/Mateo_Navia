namespace Clase12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatosTipoCliente : DbMigration
    {
        public override void Up()
        {
			Sql("INSERT INTO TipoClientes(Id,Nombre,CostoSuscripcion,DuracionSubEnMeses,PorcDescuento) VALUES (1,paga lo que lleva,0,0,0)");
			Sql("INSERT INTO TipoClientes(Id,Nombre,CostoSuscripcion,DuracionSubEnMeses,PorcDescuento) VALUES (2,Mensual,30,1,10)");
			Sql("INSERT INTO TipoClientes(Id,Nombre,CostoSuscripcion,DuracionSubEnMeses,PorcDescuento) VALUES (3,quincenal,90,3,15,)");
			Sql("INSERT INTO TipoClientes(Id,Nombre,CostoSuscripcion,DuracionSubEnMeses,PorcDescuento) VALUES (4,anual,300,12,20,)");
		}
        
        public override void Down()
        {
        }
    }
}
