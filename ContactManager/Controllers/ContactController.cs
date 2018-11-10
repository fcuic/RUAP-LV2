using ContactManager.Models;
using ContactManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactManager.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        public Contact[] Get()
        {
            return this.contactRepository.GetAllContacts();
            {
                /* new Contact
                 {
                     Id = 1,
                     Name = "Glenn Block"
                 };
                 new Contact
                 {
                     Id = 2,
                     Name = "Dan Roth"
                 };
             };*/
            }
            /*public string[] Get()
            {
                return new string[]
        {
            "Hello",
            "World"
        };
            }*/
        }
        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
    }
}
