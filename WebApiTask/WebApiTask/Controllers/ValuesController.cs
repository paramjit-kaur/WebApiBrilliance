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
        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ValuesController));  //Declaring Log4Net  

        public ValuesController()
        {
            this.service = new ContactsService();
        }

        // GET api/values
        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();

            logger.Info("Fetching list of contacts");
            try
            {
                contacts = service.GetAll();
                logger.Info("Fetched list of contacts");
           
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
            return contacts;
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