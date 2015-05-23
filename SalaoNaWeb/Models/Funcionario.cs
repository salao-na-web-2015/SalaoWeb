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
        public int funcId { get; set; }

        [Display(Name = "Funcionário")]
        public String nomeFunc { get; set; }

        [Display(Name = "Cnpj")]
        [Required(ErrorMessage = "Favor informar um cnpj.")]
        [StringLength(11, ErrorMessage = "O Cnpj deve conter somente 14 caracteres.")]
        public String cnpj { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Favor informar um e-mail.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 100 caracteres.")]
        public String email { get; set; }

        [Display(Name = "Salário")]
        [Required(ErrorMessage = "Favor informar um salário.")]
        public Double salario { get; set; }

        public virtual ICollection<Agenda> Agenda { get; set; }

    }
}