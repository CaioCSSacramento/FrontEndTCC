using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using appTCC.Models;

namespace appTCC.Util
{
    class Web
    {
        public HttpClient client = new HttpClient();

        public Web()
        {
            //atribuir o IP do servidor da Amazon para o HTTPClient
            client.BaseAddress = new Uri("http://18.188.124.204");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
