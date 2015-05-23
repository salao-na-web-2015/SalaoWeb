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
        public int cliId { get; set; }

        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Favor informar um nome.")]
        public String nomeCli { get; set; }

        [Display(Name = "Cpf")]
        [Required(ErrorMessage = "Favor informar um cpf.")]
        [StringLength(11, ErrorMessage = "O Cpf deve conter somente 11 caracteres.")]
        public String cpf { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Favor informar um e-mail.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 100 caracteres.")]
        public String email { get; set; }
        
        [Display(Name = "Contato")]
        [Required(ErrorMessage = "Favor informar uma forma de contato.")]
        [StringLength(12)]
        public String contato { get; set; }
    }
}