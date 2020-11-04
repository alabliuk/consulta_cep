using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace consulta_cep_core.Utils
{
    public class ApiRequest
    {
        public string ServiceRequest(string _urlApi)
        {
            HttpResponseMessage respApi;
            string respApiJson = string.Empty;

            using (var client = new HttpClient())
            {
                respApi = client.GetAsync(_urlApi).Result;
            }

            if (respApi.StatusCode == HttpStatusCode.OK)
            {
                respApiJson = respApi.Content.ReadAsStringAsync().Result;
            }

            return respApiJson;
        }
    }
}
