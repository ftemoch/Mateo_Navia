namespace Clase12.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class tarifaVlrs : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Tarifas",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Nombre = c.String(),
					Costo = c.Double(nullable: false),
					Descuento = c.Double(nullable: false),
					Fecha = c.String(),
				})
				.PrimaryKey(t => t.Id);

		}

		public override void Down()
		{
			DropTable("dbo.Tarifas");
		}
	}
}

