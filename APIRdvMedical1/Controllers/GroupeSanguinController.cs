using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class GroupeSanguinController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        public IEnumerable<GroupeSanguin> Get()
        {
            return db.GroupesSanguins.ToList();
        }

        public IHttpActionResult Get(int id)
        {
            var groupe = db.GroupesSanguins.FirstOrDefault(g => g.IdGGroupeSanguin == id);
            if (groupe == null) return NotFound();

            return Ok(groupe);
        }

        public IHttpActionResult Post([FromBody] GroupeSanguin groupe)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            db.GroupesSanguins.Add(groupe);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = groupe.IdGGroupeSanguin }, groupe);
        }

        public IHttpActionResult Put(int id, [FromBody] GroupeSanguin groupe)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.GroupesSanguins.FirstOrDefault(g => g.IdGGroupeSanguin == id);
            if (existing == null) return NotFound();

            existing.CodeGroupeSanguin = groupe.CodeGroupeSanguin;

            db.SaveChanges();
            return Ok(existing);
        }

        public IHttpActionResult Delete(int id)
        {
            var groupe = db.GroupesSanguins.FirstOrDefault(g => g.IdGGroupeSanguin == id);
            if (groupe == null) return NotFound();

            db.GroupesSanguins.Remove(groupe);
            db.SaveChanges();

            return Ok();
        }
    }
}
