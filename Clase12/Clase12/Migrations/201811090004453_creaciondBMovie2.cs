namespace Clase12.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class creaciondBMovie2 : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Movies",
				c => new
				{
					ID = c.Int(nullable: false, identity: true),
					Nombre = c.String(),
					Genero = c.String(),
				})
				.PrimaryKey(t => t.ID);
			
		}

		public override void Down()
		{			
			DropTable("dbo.Movies");
		}
	}
}
