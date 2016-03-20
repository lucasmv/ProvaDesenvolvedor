namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Enum : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produtoes", "Promocao_Id", "dbo.PromocaoBases");
            DropIndex("dbo.Produtoes", new[] { "Promocao_Id" });
            AddColumn("dbo.Produtoes", "Promocao", c => c.Int(nullable: false));
            DropColumn("dbo.Produtoes", "Promocao_Id");
            DropTable("dbo.PromocaoBases");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PromocaoBases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Produtoes", "Promocao_Id", c => c.Int());
            DropColumn("dbo.Produtoes", "Promocao");
            CreateIndex("dbo.Produtoes", "Promocao_Id");
            AddForeignKey("dbo.Produtoes", "Promocao_Id", "dbo.PromocaoBases", "Id");
        }
    }
}
