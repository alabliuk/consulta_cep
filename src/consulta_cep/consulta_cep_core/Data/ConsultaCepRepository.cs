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
        public List<string> GetAllPendingProcess()
        {
            List<string> lCep;

            using (IDbConnection con = new SqlConnection(ConnString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                lCep = con.Query<string>("GetAllListCeps", null, commandType: CommandType.StoredProcedure).ToList();
            }

            return lCep;
        }

        public int SaveCepProcessed(ConsultaCep cp)
        {
            int rows = 0;
            using (IDbConnection con = new SqlConnection(ConnString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                var vParams = new DynamicParameters();
                vParams.Add("@Cep", cp.Cep.Replace("-", ""));
                vParams.Add("@Logradouro", cp.Logradouro);
                vParams.Add("@Complemento", cp.Complemento);
                vParams.Add("@Bairro", cp.Bairro);
                vParams.Add("@Localidade", cp.Localidade);
                vParams.Add("@Uf", cp.Uf);
                vParams.Add("@Ibge", cp.Ibge);
                vParams.Add("@Gia", cp.Gia);
                vParams.Add("@Ddd", cp.Ddd);
                vParams.Add("@Siafi", cp.Siafi);

                rows = con.QuerySingle<int>("SaveCepProcessed", vParams, commandType: CommandType.StoredProcedure);
            }

            return rows;
        }
    }
}
