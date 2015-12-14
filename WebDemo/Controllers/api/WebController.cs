using System.Collections.Generic;
using System.Net.Mime;
using System.Web.Http;
using WebDemo.Models;

namespace WebDemo.Controllers.api
{
    public class WebController : ApiController
    {
        private ReservationRespository _repo = ReservationRespository.Current;

        // GET: api/Web
        public IEnumerable<Reservation> Get()
        {
            return _repo.GetAll();
        }

        // GET: api/Web/5
        public Reservation Get(int id)
        {
            return _repo.Get(id);
        }

        // POST: api/Web
        [HttpPost]
        public Reservation Post([FromBody] Reservation item)
        {
            //  Reservation newRes = new Reservation {ClientName = ClientName, Location = Location};

            return _repo.Add(item);
        }

        // PUT: api/Web/5
        [HttpPut]
        public bool Put(int id, [FromBody]Reservation item)
        {
            return _repo.Update(item);
        }

        // DELETE: api/Web/5
        public void Delete(int id)
        {
            _repo.Remove(id);
        }
    }
}
