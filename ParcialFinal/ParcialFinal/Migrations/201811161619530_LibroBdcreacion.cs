namespace ParcialFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibroBdcreacion : DbMigration
    {
        public override void Up()
        {
			CreateTable(
				"dbo.Libroes",
				c => new
				{
					ID = c.Int(nullable: false, identity: true),
					Titulo = c.String(),
					Autor = c.String(),
					Edicion = c.Double(nullable: false),
					ISBN = c.Double(nullable: false),
				})
				.PrimaryKey(t => t.ID);
		}
        
        public override void Down()
        {
			DropTable("dbo.Libroes");
		}
    }
}
