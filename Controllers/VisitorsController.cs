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
    public class VisitorsController : ControllerBase
    {
        // GET: api/Visitors
        [HttpGet]
        public IEnumerable<Visitor> Get()
        {
            using (var contaxt = new ApplicationDbContext())
            {
                var visitors = contaxt.Visitors.ToArray();
                return visitors;
            }
        }

        // GET: api/Visitors/5
        [HttpGet("{id}")]
        public Visitor Get(int id)
        {
            using (var contaxt = new ApplicationDbContext())
            {
                var visitors = contaxt.Visitors.Find(id);
                return visitors;
            }
        }

        // POST: api/Visitors
        [HttpPost]
        public void Post(Visitor request)
        {
            var visitor = new Visitor
            {
                Förnamn = request.Förnamn,
                Efternamn = request.Efternamn,
                Mail = request.Mail,
                seminarId = 1
            };

            using (var contaxt = new ApplicationDbContext())
            {
                contaxt.Visitors.Add(visitor);

                contaxt.SaveChanges();
            }

        }

        // PUT: api/Visitors/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}