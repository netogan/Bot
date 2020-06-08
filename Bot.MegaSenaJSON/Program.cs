using Bot.MegaSenaJSON.Models;
using Newtonsoft.Json;
using System;
using System.Net;

namespace Bot.MegaSenaJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do concurso:");
            var numeroConcurso = Console.ReadLine();

            if (string.IsNullOrEmpty(numeroConcurso))
                numeroConcurso = "2103";

            var url = $"http://loterias.caixa.gov.br/wps/portal/loterias/landing/megasena/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbwMPI0sDBxNXAOMwrzCjA0sjIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wNnUwNHfxcnSwBgIDUyhCvA5EawAjxsKckMjDDI9FQE-F4ca/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_HGK818G0KO6H80AU71KG7J0072/res/id=buscaResultado/c=cacheLevelPage/=/?timestampAjax=1591592388584&concurso={numeroConcurso}";
            var json = string.Empty;

            using (var client = new WebClient())
            {
                client.Headers["Cookie"] = "security=true";

                json = client.DownloadString(url);
            }

            var response = JsonConvert.DeserializeObject<ResponseResultado>(json);

            Console.WriteLine();
            Console.WriteLine(response.ResultadoOrdenado);

            Console.ReadKey();
        }
    }
}
