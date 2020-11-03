using consulta_cep_core.Data;
using consulta_cep_core.Models;
using System.Collections.Generic;

namespace consulta_cep_core.Business
{
    public class ConsultaCepController
    {
        public List<ConsultaCep> GetAllPendingProcess()
        {
            return new ConsultaCepRepository().GetAllPendingProcess();
        }
    }
}
