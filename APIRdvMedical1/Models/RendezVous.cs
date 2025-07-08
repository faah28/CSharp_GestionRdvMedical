using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRdvMedical1.Model
{
    /// <summary>
    /// Représente un rendez-vous médical dans le système.
    /// </summary>
    public class RendezVous
    {
        /// <summary>
        /// Identifiant unique du rendez-vous.
        /// </summary>
        [Key]
        public int IdRv { get; set; }

        /// <summary>
        /// Date du rendez-vous.
        /// </summary>
        [Required]
        public DateTime DateRv { get; set; }

        /// <summary>
        /// Statut du rendez-vous (ex : Confirmé, Annulé, Terminé).
        /// </summary>
        [MaxLength(10)]
        public string Statut { get; set; }

        /// <summary>
        /// Heure du rendez-vous (format HH:mm).
        /// </summary>
        [Required]
        public string HeureRv { get; set; }

        /// <summary>
        /// Clé étrangère vers le soin associé (optionnel).
        /// </summary>
        public int? IdSoin { get; set; }

        /// <summary>
        /// Navigation vers l'entité Soin liée au rendez-vous.
        /// </summary>
        [ForeignKey("IdSoin")]
        public virtual Soin Soin { get; set; }

        /// <summary>
        /// Clé étrangère vers le patient concerné (optionnel).
        /// </summary>
        public int? IdPatient { get; set; }

        /// <summary>
        /// Navigation vers l'entité Patient concerné.
        /// </summary>
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }

        /// <summary>
        /// Clé étrangère vers le médecin concerné (optionnel).
        /// </summary>
        public int? IdMedecin { get; set; }

        /// <summary>
        /// Navigation vers le médecin affecté au rendez-vous.
        /// </summary>
        [ForeignKey("IdMedecin")]
        public virtual Medecin Medecin { get; set; }

        /// <summary>
        /// Clé étrangère vers l'agenda utilisé pour planifier ce rendez-vous (optionnel).
        /// </summary>
        public int? IdAgenda { get; set; }

        /// <summary>
        /// Navigation vers l'agenda associé.
        /// </summary>
        [ForeignKey("IdAgenda")]
        public virtual Agenda Agenda { get; set; }
    }
}
