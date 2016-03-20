namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BdAddPromocao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PromocaoBases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Produtoes", "Promocao_Id", c => c.Int());
            CreateIndex("dbo.Produtoes", "Promocao_Id");
            AddForeignKey("dbo.Produtoes", "Promocao_Id", "dbo.PromocaoBases", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "Promocao_Id", "dbo.PromocaoBases");
            DropIndex("dbo.Produtoes", new[] { "Promocao_Id" });
            DropColumn("dbo.Produtoes", "Promocao_Id");
            DropTable("dbo.PromocaoBases");
        }
    }
}
