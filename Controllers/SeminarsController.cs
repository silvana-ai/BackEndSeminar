using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignToSeminarie;

namespace SignToSeminarBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeminarsController : ControllerBase
    {
        // GET: api/Seminars
        [HttpGet]
        public IEnumerable<Seminar> Get()
        {
            using (var contaxt = new ApplicationDbContext())
            {
                var seminars = contaxt.Seminars.ToArray();
                return seminars;
            }
        }

        // GET: api/Seminars/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            using (var contaxt = new ApplicationDbContext())
            {
                var seminar = contaxt.Seminars.Find(id);

                if (seminar == null)
                {
                    return NotFound("Could not found seminar");
                }

                return Ok(seminar);
            }

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            using (var contaxt = new ApplicationDbContext())
            {
                var seminar = contaxt.Seminars.Find(id);

                if (seminar == null)
                {
                    return BadRequest("Error deleting seminar");
                }

                contaxt.Seminars.Remove(seminar);
                contaxt.SaveChanges();

                return Ok();
            }
        }

        // POST: api/Seminars
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}