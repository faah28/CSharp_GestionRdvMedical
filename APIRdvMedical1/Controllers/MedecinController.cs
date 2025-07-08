using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    /// <summary>
    /// API REST pour la gestion des médecins.
    /// Permet d'effectuer les opérations CRUD sur les entités Medecin.
    /// </summary>
    public class MedecinController : ApiController
    {
        // Contexte de base de données
        private BdRvMedicalContext db = new BdRvMedicalContext();

        /// <summary>
        /// GET: api/Medecin
        /// Récupère la liste complète des médecins avec leur spécialité.
        /// </summary>
        /// <returns>Liste des médecins</returns>
        public IEnumerable<Medecin> Get()
        {
            // Chargement des médecins avec relation vers leur spécialité
            return db.Medecins.Include("Specialite").ToList();
        }

        /// <summary>
        /// GET: api/Medecin/{id}
        /// Récupère un médecin spécifique par son identifiant.
        /// </summary>
        /// <param name="id">Identifiant du médecin</param>
        /// <returns>Objet Medecin ou erreur 404</returns>
        public IHttpActionResult Get(int id)
        {
            var medecin = db.Medecins.FirstOrDefault(m => m.IdU == id);
            if (medecin == null)
                return NotFound(); // 404 si non trouvé

            return Ok(medecin); // 200 OK avec données
        }

        /// <summary>
        /// POST: api/Medecin
        /// Crée un nouveau médecin.
        /// </summary>
        /// <param name="medecin">Données du médecin</param>
        /// <returns>HTTP 201 Created avec le médecin ou 400 si invalide</returns>
        public IHttpActionResult Post([FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // validation échouée

            db.Medecins.Add(medecin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = medecin.IdU }, medecin);
        }

        /// <summary>
        /// PUT: api/Medecin/{id}
        /// Met à jour les informations d’un médecin existant.
        /// </summary>
        /// <param name="id">ID du médecin</param>
        /// <param name="medecin">Données à mettre à jour</param>
        /// <returns>HTTP 200 OK ou 404 si non trouvé</returns>
        public IHttpActionResult Put(int id, [FromBody] Medecin medecin)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existing = db.Medecins.FirstOrDefault(m => m.IdU == id);
            if (existing == null)
                return NotFound();

            // Mise à jour des champs communs (hérités)
            existing.NomPrenom = medecin.NomPrenom;
            existing.Adresse = medecin.Adresse;
            existing.Email = medecin.Email;
            existing.Tel = medecin.Tel;
            existing.Identifiant = medecin.Identifiant;
            existing.MotDePasse = medecin.MotDePasse;
            existing.Statut = medecin.Statut;
            existing.IdRole = medecin.IdRole;

            // Mise à jour des champs spécifiques à Medecin
            existing.NumeroOrdre = medecin.NumeroOrdre;
            existing.IdSpecialite = medecin.IdSpecialite;

            db.SaveChanges();
            return Ok(existing);
        }

        /// <summary>
        /// DELETE: api/Medecin/{id}
        /// Supprime un médecin par son ID.
        /// </summary>
        /// <param name="id">ID du médecin</param>
        /// <returns>HTTP 200 OK ou 404 si inexistant</returns>
        public IHttpActionResult Delete(int id)
        {
            var medecin = db.Medecins.FirstOrDefault(m => m.IdU == id);
            if (medecin == null)
                return NotFound();

            db.Medecins.Remove(medecin);
            db.SaveChanges();

            return Ok(); // succès de la suppression
        }
    }
}
