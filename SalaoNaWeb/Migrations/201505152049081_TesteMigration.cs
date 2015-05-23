namespace SalaoNaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TesteMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Empresas", "cid_cidCod", "dbo.Cidades");
            DropIndex("dbo.Empresas", new[] { "cid_cidCod" });
            AddColumn("dbo.Empresas", "cidCod", c => c.Int(nullable: false));
            CreateIndex("dbo.Empresas", "cidCod");
            AddForeignKey("dbo.Empresas", "cidCod", "dbo.Cidades", "cidCod", cascadeDelete: true);
            DropColumn("dbo.Empresas", "cidadeNome");
            DropColumn("dbo.Empresas", "cidadeUf");
            DropColumn("dbo.Empresas", "cid_cidCod");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empresas", "cid_cidCod", c => c.Int());
            AddColumn("dbo.Empresas", "cidadeUf", c => c.String());
            AddColumn("dbo.Empresas", "cidadeNome", c => c.String());
            DropForeignKey("dbo.Empresas", "cidCod", "dbo.Cidades");
            DropIndex("dbo.Empresas", new[] { "cidCod" });
            DropColumn("dbo.Empresas", "cidCod");
            CreateIndex("dbo.Empresas", "cid_cidCod");
            AddForeignKey("dbo.Empresas", "cid_cidCod", "dbo.Cidades", "cidCod");
        }
    }
}
