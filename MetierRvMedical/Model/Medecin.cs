﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetierRvMedical.Model
{ 
    public class Medecin : Utilisateur
    {
        //[MaxLength(100)]
        //public string Specialite { get; set; }
        public int IdSpecialite { get; set; }

        [ForeignKey("IdSpecialite")]
        public Specialite Specialite { get; set; }

        [MaxLength(10)]
        public string NumeroOrdre { get; set; }
        public virtual ICollection<Agenda> agenda { get; set; }

    }
}
