using System.Web.Http;
using WebDemo.Models;

namespace WebDemo.Controllers.api
{
    public class ContactsController : ApiController
    {

        private ContactData getContactSeed()
        {
            var seed = new ContactData
            {
                LastName = "Johanssen",
                FirstName = "Scarlett"
            };
            return seed;
        }





        // GET api/<controller>
        public Contact Get()
        {
            //ContactData starterContact = getContactSeed();
            //return new List<ContactData>() { starterContact };

            var contact = new Contact
            {
                Name = new Name
                {
                    FirstName = "Scarlett",
                    LastName = "Johanssen"
                },
                Address = new Address()
                {
                    City = "Fruitport",
                    State = "MI",
                    Street = "2102 Gateway Dr."
                }
            };

            return contact;
        }


        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}