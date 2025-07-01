using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class RendezVousController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        public IEnumerable<RendezVous> Get()
        {
            return db.RendezVous.Include("Patient").Include("Medecin").Include("Soin").Include("Agenda").ToList();
        }

        public IHttpActionResult Get(int id)
        {
            var rv = db.RendezVous.FirstOrDefault(r => r.IdRv == id);
            if (rv == null) return NotFound();

            return Ok(rv);
        }

        public IHttpActionResult Post([FromBody] RendezVous rv)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            db.RendezVous.Add(rv);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rv.IdRv }, rv);
        }

        public IHttpActionResult Put(int id, [FromBody] RendezVous rv)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.RendezVous.FirstOrDefault(r => r.IdRv == id);
            if (existing == null) return NotFound();

            existing.DateRv = rv.DateRv;
            existing.Statut = rv.Statut;
            existing.HeureRv = rv.HeureRv;
            existing.IdSoin = rv.IdSoin;
            existing.IdPatient = rv.IdPatient;
            existing.IdMedecin = rv.IdMedecin;
            existing.IdAgenda = rv.IdAgenda;

            db.SaveChanges();
            return Ok(existing);
        }

        public IHttpActionResult Delete(int id)
        {
            var rv = db.RendezVous.FirstOrDefault(r => r.IdRv == id);
            if (rv == null) return NotFound();

            db.RendezVous.Remove(rv);
            db.SaveChanges();

            return Ok();
        }
    }
}
