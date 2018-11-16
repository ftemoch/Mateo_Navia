namespace ParcialFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipoLibrosDb : DbMigration
    {
        public override void Up()
        {
			CreateTable(
				"dbo.TipoLibroes",
				c => new
				{
					Id = c.Byte(nullable: false),
					Nombre = c.String(),
				})
				.PrimaryKey(t => t.Id);

			AddColumn("dbo.Libroes", "tipoLibro_Id", c => c.Byte());
			CreateIndex("dbo.Libroes", "tipoLibro_Id");
			AddForeignKey("dbo.Libroes", "tipoLibro_Id", "dbo.TipoLibroes", "Id");
		}
        
        public override void Down()
        {
			DropForeignKey("dbo.Libroes", "tipoLibro_Id", "dbo.TipoLibroes");
			DropIndex("dbo.Libroes", new[] { "tipoLibro_Id" });
			DropColumn("dbo.Libroes", "tipoLibro_Id");
			DropTable("dbo.TipoLibroes");
		}
    }
}
