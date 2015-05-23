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
        public int empId { get; set; }

        [Display(Name = "Razão Social")]
        public String razSoc { get; set; }

        [Display(Name = "Nome Fantasia")]
        public String nomFant { get; set; }

        [Display(Name = "Cnpj")]
        public String cnpj { get; set; }

        [Display(Name = "Cidade")]
        public int cidId { get; set; }

        public virtual Cidade Cidade { get; set; }

        public virtual ICollection<Agenda> Agenda { get; set; }
    }

}