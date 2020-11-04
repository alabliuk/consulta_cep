using consulta_cep_core.Data;
using consulta_cep_core.Models;
using consulta_cep_core.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace consulta_cep_core.Controller
{
    public class ConsultaCepController
    {
        public List<string> GetAllPendingProcess()
        {
            return new ConsultaCepRepository().GetAllPendingProcess();
        }

        public ConsultaCep ProcessCep(string cep)
        {
            var url = new Util().ViaCepUrlBuilder(cep);
            var respApiJson = new ApiRequest().ServiceRequest(url);

            ConsultaCep conCep = JsonConvert.DeserializeObject<ConsultaCep>(respApiJson);

            return conCep;
        }

        public int SaveCepProcessed(ConsultaCep cp)
        {
            return new ConsultaCepRepository().SaveCepProcessed(cp);
        }
    }
}
