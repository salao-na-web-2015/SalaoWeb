using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalaoNaWeb.Models
{
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int empCod { get; set; }

        [Display(Name = "Razão Social")]
        public String razSoc { get; set; }

        [Display(Name = "Nome Fantasia")]
        public String nomFant { get; set; }

        [Display(Name = "Cnpj")]
        public String cnpj { get; set; }

        public Cidade cid { get; set; }

        [Display(Name = "Cidade")]
        public String cidadeNome {get; set;}

        [Display(Name = "Estado")]
        public String cidadeUf { get; set; }
    }

}