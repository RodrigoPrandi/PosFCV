namespace MinhaLocadora.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarrosModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(),
                        Marca = c.String(),
                        AnoFabricacao = c.DateTime(nullable: false),
                        PessoaModelsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PessoaModels", t => t.PessoaModelsId, cascadeDelete: true)
                .Index(t => t.PessoaModelsId);
            
            CreateTable(
                "dbo.PessoaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cpf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarrosModels", "PessoaModelsId", "dbo.PessoaModels");
            DropIndex("dbo.CarrosModels", new[] { "PessoaModelsId" });
            DropTable("dbo.PessoaModels");
            DropTable("dbo.CarrosModels");
        }
    }
}
