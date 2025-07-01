using APIRdvMedical1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIRdvMedical1.Controllers
{
    public class SoinController : ApiController
    {
        private BdRvMedicalContext db = new BdRvMedicalContext();

        public IEnumerable<Soin> Get()
        {
            return db.Soins.ToList();
        }

        public IHttpActionResult Get(int id)
        {
            var soin = db.Soins.FirstOrDefault(s => s.IdSoin == id);
            if (soin == null) return NotFound();

            return Ok(soin);
        }

        public IHttpActionResult Post([FromBody] Soin soin)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            db.Soins.Add(soin);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = soin.IdSoin }, soin);
        }

        public IHttpActionResult Put(int id, [FromBody] Soin soin)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var existing = db.Soins.FirstOrDefault(s => s.IdSoin == id);
            if (existing == null) return NotFound();

            existing.nomSoin = soin.nomSoin;
            existing.Cout = soin.Cout;

            db.SaveChanges();
            return Ok(existing);
        }

        public IHttpActionResult Delete(int id)
        {
            var soin = db.Soins.FirstOrDefault(s => s.IdSoin == id);
            if (soin == null) return NotFound();

            db.Soins.Remove(soin);
            db.SaveChanges();

            return Ok();
        }
    }
}
