using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;

namespace ContactWebPack
{
    public static class Formatters
    {
        public static readonly MediaTypeHeaderValue JSON = new MediaTypeHeaderValue("application/vnd.nuget.ContactWebPack+json");
        public static readonly MediaTypeHeaderValue XML = new MediaTypeHeaderValue("application/vnd.nuget.ContactWebPack+xml");

        public static IEnumerable<MediaTypeFormatter> Available
        {
            get { return new List<MediaTypeFormatter>()
                             {
                                 new WebPackContactJsonFormatter(),
                                 new WebPackContactXmlFormatter()
                             }; }
        }
    }
}
