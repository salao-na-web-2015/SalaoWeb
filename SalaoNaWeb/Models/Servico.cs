using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalaoNaWeb.Models
{
    public class Servico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int servCod { get; set; }

        [Display(Name = "Descrição")]
        public String nomeServ { get; set; }

        [Display(Name = "Valor")]
        public Double valor { get; set; }


    }
}