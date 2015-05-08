using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalaoNaWeb.Models
{
    public class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int funcCod { get; set; }

        [Display(Name = "Nome")]
        public String nomeFunc { get; set; }

        [Display(Name = "Cpf")]
        public String cpfCnpj { get; set; }

        [Display(Name = "Email")]
        public String email { get; set; }

        [Display(Name = "Salario")]
        public Double salario { get; set; }

    }
}