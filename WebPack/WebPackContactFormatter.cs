using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace ContactWebPack
{
    public class WebPackContactXmlFormatter: XmlMediaTypeFormatter
    {
        public WebPackContactXmlFormatter()
        {
            SupportedMediaTypes.Add(Formatters.XML);
        }
    }

    public class WebPackContactJsonFormatter : JsonMediaTypeFormatter
    {
        public WebPackContactJsonFormatter()
        {
            SupportedMediaTypes.Add(Formatters.JSON);
        }
    }
}
