using consulta_cep_core.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace consulta_cep_core.Data
{
    class ConsultaCepRepository : Conn
    {
        public List<ConsultaCep> GetAllPendingProcess()
        {
            List<ConsultaCep> lCep;

            using (IDbConnection con = new SqlConnection(ConnString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                lCep = con.Query<ConsultaCep>("xxxxx", null, commandType: CommandType.StoredProcedure).ToList();
            }

            return lCep;
        }
    }
}
