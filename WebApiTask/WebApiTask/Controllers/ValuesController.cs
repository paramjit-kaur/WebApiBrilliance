using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTask.Models;

namespace WebApiTask.Controllers
{
    public class ValuesController : ApiController
    {
        private ContactsService service;

        public ValuesController()
        {
            this.service = new ContactsService();
        }

        // GET api/values
        public List<Contact> GetContacts()
        {
            return service.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}