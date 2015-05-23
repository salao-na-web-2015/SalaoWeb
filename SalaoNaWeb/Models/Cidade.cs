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
        public int cidId {get; set;}
        [Display(Name = "Cidade")]
        public string cidNom { get; set; }
        [Display(Name = "UF")]
        public string cidUf { get; set; }
        public virtual ICollection<Empresa> Empresa { get; set; }
        
    }
}