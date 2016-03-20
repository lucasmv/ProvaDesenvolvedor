namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste31 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtoes", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtoes", "Nome", c => c.String());
        }
    }
}
