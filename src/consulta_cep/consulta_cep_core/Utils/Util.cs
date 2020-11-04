using System;
using System.Collections.Generic;
using System.Text;

namespace consulta_cep_core.Utils
{
    public class Util
    {
        public string ViaCepUrlBuilder(string cep)
        {
            var config = new JsonTools().ReadTokensAppsettings();
            string _urlBase = config.GetSection("API_Access:API_Via_Cep:UrlBase").Value;
            string _urlFinal = "/json/";
            return _urlBase + cep + _urlFinal;
        }
    }
}
