using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using ContactWebPack;

namespace WebAPI.Controllers
{
    public class ContactController : ApiController
    {
        public
        Contact[] _Contacts = { new Contact() {FirstName = "Bob", LastName = "Brown"},
                                new Contact() {FirstName = "Mary", LastName = "Smith"},
                                new Contact() {FirstName = "Dave", LastName = "Wood"}};
        
        public HttpResponseMessage<Contact> Get(int id)
        {
            var contact = _Contacts[id];
            
            return new HttpResponseMessage<Contact>(contact,ContactWebPack.Formatters.XML);
        }

        public HttpResponseMessage<Contact> Post(Contact contact)
        {
            var response = new HttpResponseMessage<Contact>(contact); 
            return response;
        }
    }
}
