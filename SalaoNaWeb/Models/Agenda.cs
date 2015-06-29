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
        public int ageId { get; set; }

        [Display(Name = "Salão")]
        [Required(ErrorMessage = "Favor informar um salão.")]
        public int empId { get; set; }
        
        public virtual Empresa Empresa { get; set; }

        [Display(Name = "Serviço")]
        [Required(ErrorMessage = "Favor informar um tipo de serviço.")]
        public int servId { get; set; }

        public virtual Servico Servico { get; set; }

        [Display(Name = "Valor")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0.00")]
        public Double valorServ { get; set; }

        [Display(Name = "Funcionário")]
        [Required(ErrorMessage = "Favor informar um profissional.")]
        public int funcId { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        [Display(Name = "Horário Inicio Agendamento")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dataHoraInicio { get; set; }

        [Display(Name = "Horário Final Agendamento")]
        public DateTime dataHoraFim { get; set; }

        

        
    }
}