﻿namespace APIRdvMedical1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutToutesEntites : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        IdU = c.Int(nullable: false, identity: true),
                        NomPrenom = c.String(nullable: false, maxLength: 160, storeType: "nvarchar"),
                        Adresse = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 80, storeType: "nvarchar"),
                        Tel = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        Identifiant = c.String(maxLength: 20, storeType: "nvarchar"),
                        MotDePasse = c.String(maxLength: 250, storeType: "nvarchar"),
                        Statut = c.Boolean(),
                        IdRole = c.Int(),
                        IdSpecialite = c.Int(),
                        NumeroOrdre = c.String(maxLength: 10, storeType: "nvarchar"),
                        GroupeSanguin = c.String(maxLength: 33, storeType: "nvarchar"),
                        Poids = c.Single(),
                        Taille = c.Single(),
                        DateNaissance = c.DateTime(precision: 0),
                        TelephoneFixe = c.String(maxLength: 15, storeType: "nvarchar"),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdU)
                .ForeignKey("dbo.Specialites", t => t.IdSpecialite, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.IdRole)
                .Index(t => t.IdRole)
                .Index(t => t.IdSpecialite);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 10, storeType: "nvarchar"),
                        Libelle = c.String(maxLength: 30, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Agenda",
                c => new
                    {
                        IdAgenda = c.Int(nullable: false, identity: true),
                        DatePlanifie = c.DateTime(precision: 0),
                        Titre = c.String(unicode: false),
                        HeureDebut = c.String(unicode: false),
                        HeureFin = c.String(unicode: false),
                        Creneau = c.Int(nullable: false),
                        Lieu = c.String(unicode: false),
                        Statut = c.String(unicode: false),
                        IdMedecin = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAgenda)
                .ForeignKey("dbo.Personnes", t => t.IdMedecin, cascadeDelete: true)
                .Index(t => t.IdMedecin);
            
            CreateTable(
                "dbo.Specialites",
                c => new
                    {
                        IdSpecialite = c.Int(nullable: false, identity: true),
                        CodeSpecialite = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        NomSpecialite = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdSpecialite);
            
            CreateTable(
                "dbo.RendezVous",
                c => new
                    {
                        IdRv = c.Int(nullable: false, identity: true),
                        DateRv = c.DateTime(nullable: false, precision: 0),
                        Statut = c.String(maxLength: 10, storeType: "nvarchar"),
                        HeureRv = c.String(nullable: false, unicode: false),
                        IdSoin = c.Int(),
                        IdPatient = c.Int(),
                        IdMedecin = c.Int(),
                        IdAgenda = c.Int(),
                    })
                .PrimaryKey(t => t.IdRv)
                .ForeignKey("dbo.Agenda", t => t.IdAgenda)
                .ForeignKey("dbo.Personnes", t => t.IdMedecin)
                .ForeignKey("dbo.Personnes", t => t.IdPatient)
                .ForeignKey("dbo.Soins", t => t.IdSoin)
                .Index(t => t.IdSoin)
                .Index(t => t.IdPatient)
                .Index(t => t.IdMedecin)
                .Index(t => t.IdAgenda);
            
            CreateTable(
                "dbo.Soins",
                c => new
                    {
                        IdSoin = c.Int(nullable: false, identity: true),
                        nomSoin = c.String(nullable: false, unicode: false),
                        Cout = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdSoin);
            
            CreateTable(
                "dbo.GroupeSanguins",
                c => new
                    {
                        IdGGroupeSanguin = c.Int(nullable: false, identity: true),
                        CodeGroupeSanguin = c.String(nullable: false, maxLength: 3, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.IdGGroupeSanguin);
            
            CreateTable(
                "dbo.Td_Erreur",
                c => new
                    {
                        idErreur = c.Int(nullable: false, identity: true),
                        DateErreur = c.DateTime(nullable: false, precision: 0),
                        TitreErreur = c.String(maxLength: 200, storeType: "nvarchar"),
                        DescriptionErreur = c.String(maxLength: 2000, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.idErreur);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personnes", "IdRole", "dbo.Roles");
            DropForeignKey("dbo.RendezVous", "IdSoin", "dbo.Soins");
            DropForeignKey("dbo.RendezVous", "IdPatient", "dbo.Personnes");
            DropForeignKey("dbo.RendezVous", "IdMedecin", "dbo.Personnes");
            DropForeignKey("dbo.RendezVous", "IdAgenda", "dbo.Agenda");
            DropForeignKey("dbo.Personnes", "IdSpecialite", "dbo.Specialites");
            DropForeignKey("dbo.Agenda", "IdMedecin", "dbo.Personnes");
            DropIndex("dbo.RendezVous", new[] { "IdAgenda" });
            DropIndex("dbo.RendezVous", new[] { "IdMedecin" });
            DropIndex("dbo.RendezVous", new[] { "IdPatient" });
            DropIndex("dbo.RendezVous", new[] { "IdSoin" });
            DropIndex("dbo.Agenda", new[] { "IdMedecin" });
            DropIndex("dbo.Personnes", new[] { "IdSpecialite" });
            DropIndex("dbo.Personnes", new[] { "IdRole" });
            DropTable("dbo.Td_Erreur");
            DropTable("dbo.GroupeSanguins");
            DropTable("dbo.Soins");
            DropTable("dbo.RendezVous");
            DropTable("dbo.Specialites");
            DropTable("dbo.Agenda");
            DropTable("dbo.Roles");
            DropTable("dbo.Personnes");
        }
    }
}
