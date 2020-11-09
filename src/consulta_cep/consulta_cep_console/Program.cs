using consulta_cep_core.Controller;
using consulta_cep_core.Models;
using consulta_cep_core.Utils;
using System;

namespace consulta_cep_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new QuickEditConsole().DisableQuickEdit();
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

            var CepsPending = new ConsultaCepController().GetAllPendingProcess();
            ConsultaCep respCep = new ConsultaCep();

            Console.WriteLine($"\nCEPS PENDENTES: {CepsPending.Count}");

            foreach (string cep in CepsPending)
            {
                Console.Write($"\n{DateTime.Now} - Processando CEP: {cep} || ");

                try
                {
                    respCep = new ConsultaCepController().ProcessCep(cep);
                }
                catch (Exception ex)
                {
                    Console.Write($" >>> Request Exception => {ex.Message}");
                }


                Console.Write($" {respCep.Uf} - {respCep.Localidade} - {respCep.Logradouro}");

                if (respCep.Cep is null)
                {
                    Console.Write(" >>> CEP INVÁLIDO!!!");
                    new ConsultaCepController().UpdateCepInvalid(cep);
                }
                else
                {
                    int rows = new ConsultaCepController().SaveCepProcessed(respCep);

                    if (rows > 0)
                        Console.Write(" >>> Processado");
                    else
                        Console.Write(" >>> Pendente");
                }
            }
        }
    }
}
