using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class AgendaController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        public IEnumerable<Agenda> Get()
        {
            return db.Agendas.ToList();
        }

        public IHttpActionResult Get(int id)
        {
            var agenda = db.Agendas.FirstOrDefault(a => a.IdAgenda == id);
            if (agenda == null) return NotFound();

            return Ok(agenda);
        }

        public IHttpActionResult Post([FromBody] Agenda agenda)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            db.Agendas.Add(agenda);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = agenda.IdAgenda }, agenda);
        }

        public IHttpActionResult Put(int id, [FromBody] Agenda agenda)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.Agendas.FirstOrDefault(a => a.IdAgenda == id);
            if (existing == null) return NotFound();

            existing.DatePlanifie = agenda.DatePlanifie;
            existing.Titre = agenda.Titre;
            existing.HeureDebut = agenda.HeureDebut;
            existing.HeureFin = agenda.HeureFin;
            existing.Creneau = agenda.Creneau;
            existing.Lieu = agenda.Lieu;
            existing.Statut = agenda.Statut;
            existing.IdMedecin = agenda.IdMedecin;

            db.SaveChanges();
            return Ok(existing);
        }

        public IHttpActionResult Delete(int id)
        {
            var agenda = db.Agendas.FirstOrDefault(a => a.IdAgenda == id);
            if (agenda == null) return NotFound();

            db.Agendas.Remove(agenda);
            db.SaveChanges();

            return Ok();
        }
    }
}
