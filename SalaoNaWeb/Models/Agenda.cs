using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalaoNaWeb.Models
{
    public class Agenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ageCod { get; set; }

        [Display(Name = "Funcionario")]
        public String nomeFunc { get; set; }

        [Display(Name = "Data")]
        public DateTime dataEHora { get; set; }

        [Display(Name = "Valor")]
        public Double valorServ { get; set; }
    }
}