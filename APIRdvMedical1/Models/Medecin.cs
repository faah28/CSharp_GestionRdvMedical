using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRdvMedical1.Model
{
    /// <summary>
    /// Représente un médecin, héritant de la classe Utilisateur.
    /// </summary>
    public class Medecin : Utilisateur
    {
        /// <summary>
        /// Identifiant de la spécialité associée au médecin.
        /// Cette propriété est la clé étrangère vers la table Specialite.
        /// </summary>
        public int IdSpecialite { get; set; }

        /// <summary>
        /// Objet navigationnel représentant la spécialité médicale du médecin.
        /// Chargé automatiquement via Entity Framework grâce à la clé étrangère.
        /// </summary>
        [ForeignKey("IdSpecialite")]
        public Specialite Specialite { get; set; }

        /// <summary>
        /// Numéro d'inscription à l'ordre des médecins.
        /// Limité à 10 caractères maximum.
        /// </summary>
        [MaxLength(10)]
        public string NumeroOrdre { get; set; }

        /// <summary>
        /// Liste des créneaux d’agenda associés au médecin.
        /// Un médecin peut avoir plusieurs agendas (rendez-vous).
        /// </summary>
        public virtual ICollection<Agenda> agenda { get; set; }
    }
}
