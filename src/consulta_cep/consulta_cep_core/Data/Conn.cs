using consulta_cep_core.Utils;

namespace consulta_cep_core.Data
{
    public abstract class Conn
    {
        public static string ConnString { get; private set; }

        public Conn()
        {
            var config = new JsonTools().ReadTokensAppsettings();
            ConnString = config.GetSection("Conn:DB").Value;
        }
    }
}
