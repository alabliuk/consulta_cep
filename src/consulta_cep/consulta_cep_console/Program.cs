using System;

namespace consulta_cep_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new consulta_cep_core.Utils.QuickEditConsole().DisableQuickEdit();
                new Program().Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"|| ERROR --> {ex.Message}");
            }
        }

        private void Run()
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine($"\tConsulta CEP [v0.1] - {DateTime.Now}");
            Console.WriteLine("==========================================================");



        }
    }
}
