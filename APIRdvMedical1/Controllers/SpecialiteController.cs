using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class SpecialiteController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        public IEnumerable<Specialite> Get()
        {
            return db.Specialites.ToList();
        }

        public IHttpActionResult Get(int id)
        {
            var spec = db.Specialites.FirstOrDefault(s => s.IdSpecialite == id);
            if (spec == null) return NotFound();

            return Ok(spec);
        }

        public IHttpActionResult Post([FromBody] Specialite specialite)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            db.Specialites.Add(specialite);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = specialite.IdSpecialite }, specialite);
        }

        public IHttpActionResult Put(int id, [FromBody] Specialite specialite)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.Specialites.FirstOrDefault(s => s.IdSpecialite == id);
            if (existing == null) return NotFound();

            existing.CodeSpecialite = specialite.CodeSpecialite;
            existing.NomSpecialite = specialite.NomSpecialite;

            db.SaveChanges();
            return Ok(existing);
        }

        public IHttpActionResult Delete(int id)
        {
            var spec = db.Specialites.FirstOrDefault(s => s.IdSpecialite == id);
            if (spec == null) return NotFound();

            db.Specialites.Remove(spec);
            db.SaveChanges();

            return Ok();
        }
    }
}
