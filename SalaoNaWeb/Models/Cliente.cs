using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalaoNaWeb.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cliCod { get; set; }

        [Display(Name = "Nome")]
        public String nomeCli { get; set; }

        [Display(Name = "Cpf")]
        public String cpfCnpj { get; set; }

        [Display(Name = "Email")]
        public String email { get; set; }
        
        [Display(Name = "Contato")]
        public String contato { get; set; }
    }
}