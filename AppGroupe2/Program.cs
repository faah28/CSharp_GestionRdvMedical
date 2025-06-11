using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGroupe2.Model;
using AppGroupe2.View;

namespace AppGroupe2
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CreateAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
        }

        static void CreateAdmin()
        {
            BdRvMedicalContext db = new BdRvMedicalContext();
            int AdminExist = db.admins.Count();
            if (AdminExist==0 )
            {
                Admin admin = new Admin();
                admin.Adresse = "Admin Adresse";
                admin.Identifiant = "Admin";
                admin.Statut = true;
                admin.Tel = "tel-Admin";
                admin.MotDePasse = Helper.CryptString.GetMd5Hash("Passer1234");
                admin.NomPrenom = "Nom-Prenom";
                admin.Email = "l3GLG2@gmail.com";
                admin.IdRole = db.roles.Where(a => a.Code.ToLower() == "admin").FirstOrDefault().Id;
                db.admins.Add(admin);
                db.SaveChanges();
            }
        }
    }
}
