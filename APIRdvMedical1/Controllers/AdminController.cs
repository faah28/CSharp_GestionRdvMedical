using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    /// <summary>
    /// Contrôleur API REST pour la gestion des administrateurs (type Admin).
    /// Permet de récupérer, ajouter, mettre à jour et supprimer des administrateurs.
    /// </summary>
    public class AdminController : ApiController
    {
        // Contexte de la base de données pour accéder aux entités
        private BdRvMedicalContext db = new BdRvMedicalContext();

        /// <summary>
        /// GET /api/admin
        /// Récupère la liste de tous les administrateurs enregistrés.
        /// </summary>
        /// <returns>Liste des objets Admin</returns>
        public IEnumerable<Admin> Get()
        {
            // On filtre les personnes pour ne récupérer que les administrateurs (héritage)
            return db.Personnes.OfType<Admin>().ToList();
        }

        /// <summary>
        /// GET /api/admin/{id}
        /// Récupère les informations d’un administrateur spécifique par ID.
        /// </summary>
        /// <param name="id">Identifiant de l'administrateur</param>
        /// <returns>Objet Admin ou erreur 404</returns>
        public IHttpActionResult Get(int id)
        {
            var admin = db.Personnes.OfType<Admin>().FirstOrDefault(a => a.IdU == id);
            if (admin == null) return NotFound(); // retourne 404 si non trouvé

            return Ok(admin); // retourne 200 + l’objet trouvé
        }

        /// <summary>
        /// POST /api/admin
        /// Ajoute un nouvel administrateur à la base.
        /// </summary>
        /// <param name="admin">Objet Admin envoyé dans le corps de la requête</param>
        /// <returns>Réponse HTTP 201 avec l'objet créé ou erreur de validation</returns>
        public IHttpActionResult Post([FromBody] Admin admin)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState); // retourne 400 si données invalides

            db.Personnes.Add(admin);
            db.SaveChanges();

            // retourne 201 Created avec lien vers la ressource créée
            return CreatedAtRoute("DefaultApi", new { id = admin.IdU }, admin);
        }

        /// <summary>
        /// PUT /api/admin/{id}
        /// Met à jour les informations d’un administrateur existant.
        /// </summary>
        /// <param name="id">ID de l'admin à modifier</param>
        /// <param name="admin">Objet Admin modifié</param>
        /// <returns>Réponse HTTP 200 avec les données mises à jour ou 404</returns>
        public IHttpActionResult Put(int id, [FromBody] Admin admin)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.Personnes.OfType<Admin>().FirstOrDefault(a => a.IdU == id);
            if (existing == null) return NotFound();

            // Mise à jour manuelle des champs
            existing.NomPrenom = admin.NomPrenom;
            existing.Adresse = admin.Adresse;
            existing.Email = admin.Email;
            existing.Tel = admin.Tel;
            existing.Identifiant = admin.Identifiant;
            existing.MotDePasse = admin.MotDePasse;
            existing.Statut = admin.Statut;
            existing.IdRole = admin.IdRole;

            db.SaveChanges();
            return Ok(existing); // retourne 200 OK avec l’objet mis à jour
        }

        /// <summary>
        /// DELETE /api/admin/{id}
        /// Supprime un administrateur de la base.
        /// </summary>
        /// <param name="id">ID de l'administrateur à supprimer</param>
        /// <returns>Réponse HTTP 200 ou 404 si non trouvé</returns>
        public IHttpActionResult Delete(int id)
        {
            var admin = db.Personnes.OfType<Admin>().FirstOrDefault(a => a.IdU == id);
            if (admin == null) return NotFound();

            db.Personnes.Remove(admin);
            db.SaveChanges();

            return Ok(); // retourne 200 OK sans contenu
        }
    }
}
