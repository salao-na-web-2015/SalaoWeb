namespace SalaoNaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationSalaoWeb1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Empresa", "Agenda_ageId", "dbo.Agenda");
            DropForeignKey("dbo.Funcionario", "Agenda_ageId", "dbo.Agenda");
            DropForeignKey("dbo.Servico", "Agenda_ageId", "dbo.Agenda");
            DropIndex("dbo.Empresa", new[] { "Agenda_ageId" });
            DropIndex("dbo.Funcionario", new[] { "Agenda_ageId" });
            DropIndex("dbo.Servico", new[] { "Agenda_ageId" });
            CreateIndex("dbo.Agenda", "empId");
            CreateIndex("dbo.Agenda", "funcId");
            CreateIndex("dbo.Agenda", "servId");
            AddForeignKey("dbo.Agenda", "empId", "dbo.Empresa", "empId", cascadeDelete: true);
            AddForeignKey("dbo.Agenda", "funcId", "dbo.Funcionario", "funcId", cascadeDelete: true);
            AddForeignKey("dbo.Agenda", "servId", "dbo.Servico", "servId", cascadeDelete: true);
            DropColumn("dbo.Empresa", "Agenda_ageId");
            DropColumn("dbo.Funcionario", "Agenda_ageId");
            DropColumn("dbo.Servico", "Agenda_ageId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Servico", "Agenda_ageId", c => c.Int());
            AddColumn("dbo.Funcionario", "Agenda_ageId", c => c.Int());
            AddColumn("dbo.Empresa", "Agenda_ageId", c => c.Int());
            DropForeignKey("dbo.Agenda", "servId", "dbo.Servico");
            DropForeignKey("dbo.Agenda", "funcId", "dbo.Funcionario");
            DropForeignKey("dbo.Agenda", "empId", "dbo.Empresa");
            DropIndex("dbo.Agenda", new[] { "servId" });
            DropIndex("dbo.Agenda", new[] { "funcId" });
            DropIndex("dbo.Agenda", new[] { "empId" });
            CreateIndex("dbo.Servico", "Agenda_ageId");
            CreateIndex("dbo.Funcionario", "Agenda_ageId");
            CreateIndex("dbo.Empresa", "Agenda_ageId");
            AddForeignKey("dbo.Servico", "Agenda_ageId", "dbo.Agenda", "ageId");
            AddForeignKey("dbo.Funcionario", "Agenda_ageId", "dbo.Agenda", "ageId");
            AddForeignKey("dbo.Empresa", "Agenda_ageId", "dbo.Agenda", "ageId");
        }
    }
}
