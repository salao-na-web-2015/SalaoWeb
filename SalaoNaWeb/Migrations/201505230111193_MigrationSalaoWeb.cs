namespace SalaoNaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationSalaoWeb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agenda",
                c => new
                    {
                        ageId = c.Int(nullable: false, identity: true),
                        empId = c.Int(nullable: false),
                        servId = c.Int(nullable: false),
                        valorServ = c.Double(nullable: false),
                        funcId = c.Int(nullable: false),
                        dataHora = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ageId);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        empId = c.Int(nullable: false, identity: true),
                        razSoc = c.String(),
                        nomFant = c.String(),
                        cnpj = c.String(),
                        cidId = c.Int(nullable: false),
                        Agenda_ageId = c.Int(),
                    })
                .PrimaryKey(t => t.empId)
                .ForeignKey("dbo.Cidade", t => t.cidId, cascadeDelete: true)
                .ForeignKey("dbo.Agenda", t => t.Agenda_ageId)
                .Index(t => t.cidId)
                .Index(t => t.Agenda_ageId);
            
            CreateTable(
                "dbo.Cidade",
                c => new
                    {
                        cidId = c.Int(nullable: false, identity: true),
                        cidNom = c.String(),
                        cidUf = c.String(),
                    })
                .PrimaryKey(t => t.cidId);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        funcId = c.Int(nullable: false, identity: true),
                        nomeFunc = c.String(),
                        cnpj = c.String(nullable: false, maxLength: 11),
                        email = c.String(nullable: false, maxLength: 100),
                        salario = c.Double(nullable: false),
                        Agenda_ageId = c.Int(),
                    })
                .PrimaryKey(t => t.funcId)
                .ForeignKey("dbo.Agenda", t => t.Agenda_ageId)
                .Index(t => t.Agenda_ageId);
            
            CreateTable(
                "dbo.Servico",
                c => new
                    {
                        servId = c.Int(nullable: false, identity: true),
                        nomeServ = c.String(),
                        valor = c.Double(nullable: false),
                        Agenda_ageId = c.Int(),
                    })
                .PrimaryKey(t => t.servId)
                .ForeignKey("dbo.Agenda", t => t.Agenda_ageId)
                .Index(t => t.Agenda_ageId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        cliId = c.Int(nullable: false, identity: true),
                        nomeCli = c.String(nullable: false),
                        cpf = c.String(nullable: false, maxLength: 11),
                        email = c.String(nullable: false, maxLength: 100),
                        contato = c.String(nullable: false, maxLength: 12),
                    })
                .PrimaryKey(t => t.cliId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Servico", "Agenda_ageId", "dbo.Agenda");
            DropForeignKey("dbo.Funcionario", "Agenda_ageId", "dbo.Agenda");
            DropForeignKey("dbo.Empresa", "Agenda_ageId", "dbo.Agenda");
            DropForeignKey("dbo.Empresa", "cidId", "dbo.Cidade");
            DropIndex("dbo.Servico", new[] { "Agenda_ageId" });
            DropIndex("dbo.Funcionario", new[] { "Agenda_ageId" });
            DropIndex("dbo.Empresa", new[] { "Agenda_ageId" });
            DropIndex("dbo.Empresa", new[] { "cidId" });
            DropTable("dbo.Cliente");
            DropTable("dbo.Servico");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Cidade");
            DropTable("dbo.Empresa");
            DropTable("dbo.Agenda");
        }
    }
}
