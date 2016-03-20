namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Produtoes", "Quantidade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produtoes", "Quantidade", c => c.Int(nullable: false));
        }
    }
}
