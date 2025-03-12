﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGroupe2.Model
{
    public class Soin
    {
        [Key] 
        public int IdSoin { get; set; }
        [Required]
        public string nomSoin { get; set; }
        public int Cout { get; set; }
    }
}
