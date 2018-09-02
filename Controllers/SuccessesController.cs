using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class SuccessesController : ControllerBase
    {
        //GET api/Successes
        [HttpGet]
		public IEnumerable<Success> Get() {
			using (SuccessDb db = new SuccessDb()) {
				return db.Successes.ToList();
			}
        }

        //GET api/Successes/5
        [HttpGet("{id}")]
		public Success Get(int id) {
			using (SuccessDb db = new SuccessDb()) {
				return db.Successes.First(Success => Success.Id == id);
			}
        }

        //POST api/Successes
        [HttpPost]
        public void Post([FromBody]JObject value) {
			Success posted = value.ToObject<Success>();
			using(SuccessDb db = new SuccessDb()) {
				db.Successes.Add(posted);
				db.SaveChanges();
			}
        }

        //PUT api/Successes/5
        [HttpPut("{id}")]
		public void Put(int id, [FromBody]JObject value) {
			Success posted = value.ToObject<Success>();
			posted.Id = id;
			using(SuccessDb db = new SuccessDb()) {
				db.Successes.Update(posted);
				db.SaveChanges();
			}
        }

        //DELETE api/Successes/5
		[HttpDelete("{id}")]
		public void Delete(int id) {
			using(SuccessDb db = new SuccessDb()) {
				if(db.Successes.Where(Success => Success.Id == id).Count() > 0) {
					db.Successes.Remove(db.Successes.First(Success => Success.Id == id));
					db.SaveChanges();
				}
			}
		}

    }
}