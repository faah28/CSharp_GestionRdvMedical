using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIRdvMedical1.Model
{
    /// <summary>
    /// Représente une secrétaire dans le système médical.
    /// Hérite des propriétés de la classe Utilisateur.
    /// </summary>
    public class Secretaire : Utilisateur
    {
        /// <summary>
        /// Numéro de téléphone fixe de la secrétaire.
        /// Limité à 15 caractères.
        /// </summary>
        [MaxLength(15)]
        public string TelephoneFixe { get; set; }
    }
}
