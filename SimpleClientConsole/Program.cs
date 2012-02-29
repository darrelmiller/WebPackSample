using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using ContactWebPack;

namespace SimpleClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();


            var response = client.GetAsync("http://localhost:9100/Contact/1").Result;
            var contact  = response.Content.ReadAsAsync<Contact>(ContactWebPack.Formatters.Available).Result;

            Console.WriteLine("{0} {1}",contact.FirstName,contact.LastName);


            var newContact = new Contact()
            {
                FirstName = "Brian",
                LastName = "Buck"
            };

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "http://localhost:9100/Contact");
            requestMessage.Content = requestMessage.CreateContent<Contact>(newContact, ContactWebPack.Formatters.XML, ContactWebPack.Formatters.Available, new FormatterSelector());
            response = client.SendAsync(requestMessage).Result;

            contact = response.Content.ReadAsAsync<Contact>(Formatters.Available).Result;
            Console.WriteLine("{0} {1}", contact.FirstName, contact.LastName);

            Console.Read();
        }
    }
}
