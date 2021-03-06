﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalaoNaWeb.Models
{
    public class Calendario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Display(Name = "Descrição")]
        public string Description { get; set; }
        //[Display(Name = "Horário Inicial")]
        public DateTime StartDate { get; set; }
        //[Display(Name = "Horário Final")]
        public DateTime EndDate { get; set; }
        public string location { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
    }
}