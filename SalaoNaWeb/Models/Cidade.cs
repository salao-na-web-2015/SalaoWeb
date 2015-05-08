using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalaoNaWeb.Models
{
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cidCod { get; set; }

        [Display(Name="Cidade")]
        public String cidNom { get; set; }

        [Display(Name = "Estado")]
        public String cidUf { get; set; }

     

        //public virtual ICollection<Empresa> empresa { get; set; }
    }
}