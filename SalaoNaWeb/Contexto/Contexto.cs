using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SalaoNaWeb.Migrations
{
    public class Contexto : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public Contexto()
            : base("name=Contexto")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Contexto, Migrations.Configuration>());
        }


        public System.Data.Entity.DbSet<SalaoNaWeb.Models.Funcionario> Funcionarios { get; set; }

        public System.Data.Entity.DbSet<SalaoNaWeb.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<SalaoNaWeb.Models.Cidade> Cidades { get; set; }

        public System.Data.Entity.DbSet<SalaoNaWeb.Models.Empresa> Empresas { get; set; }

        public System.Data.Entity.DbSet<SalaoNaWeb.Models.Servico> Servicos { get; set; }

        public System.Data.Entity.DbSet<SalaoNaWeb.Models.Agenda> Agendas { get; set; }

    }
}
