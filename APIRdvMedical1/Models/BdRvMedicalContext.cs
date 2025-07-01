using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework; // pour MySQL
using APIRdvMedical1.Model;       // ✅ pour les entités

namespace APIRdvMedical1.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdRvMedicalContext : DbContext
    {
        public BdRvMedicalContext() : base("BdRvMedicalContext") { }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Secretaire> Secretaires { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<GroupeSanguin> GroupesSanguins { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Soin> Soins { get; set; }
        public DbSet<Td_Erreur> Td_Erreurs { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuration du mapping par héritage TPH pour Personne
            modelBuilder.Entity<Personne>()
                .Map<Utilisateur>(m => m.Requires("Discriminator").HasValue("Utilisateur"))
                .Map<Patient>(m => m.Requires("Discriminator").HasValue("Patient"))
                .Map<Medecin>(m => m.Requires("Discriminator").HasValue("Medecin"))
                .Map<Secretaire>(m => m.Requires("Discriminator").HasValue("Secretaire"))
                .Map<Admin>(m => m.Requires("Discriminator").HasValue("Admin"));

            // Configuration des clés étrangères optionnelles si besoin
            modelBuilder.Entity<Medecin>()
                .HasRequired(m => m.Specialite)
                .WithMany(s => s.Medecins)
                .HasForeignKey(m => m.IdSpecialite)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Utilisateur>()
                .HasOptional(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.IdRole)
                .WillCascadeOnDelete(false);

            // Pour éviter que EF tente de supprimer des entités liées en cascade
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention>();
        }

    }



}
