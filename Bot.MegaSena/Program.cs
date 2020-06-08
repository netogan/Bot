using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Bot.MegaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do concurso:");
            var numeroConcurso = Console.ReadLine();

            if (string.IsNullOrEmpty(numeroConcurso))
                numeroConcurso = "2103";

            var url = $"http://www1.caixa.gov.br/loterias/loterias/megasena/megasena_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtConcurso={numeroConcurso}";
            var html = string.Empty;

            using (var client = new WebClient())
            {
                client.Headers["Cookie"] = "security=true";

                html = client.DownloadString(url);
            }

            html = html.Replace("<span class=\"num_sorteio\"><ul>", "");
            html = html.Replace("</ul></span>", "");
            html = html.Replace("</li>", "");

            var tagsLi = Regex.Split(html, "<li>");

            var resultado = new List<int>();

            resultado.Add(int.Parse(tagsLi[1]));
            resultado.Add(int.Parse(tagsLi[2]));
            resultado.Add(int.Parse(tagsLi[3]));
            resultado.Add(int.Parse(tagsLi[4]));
            resultado.Add(int.Parse(tagsLi[5]));
            resultado.Add(int.Parse(tagsLi[6].Substring(0, 2)));

            Console.WriteLine();
            Console.WriteLine($"Concurso selecionado: {numeroConcurso}");

            Console.WriteLine();
            Console.WriteLine($"Resultado:");

            resultado.OrderBy(x => x).ToList().ForEach(n =>
            {
                Console.WriteLine(n);
            });

            Console.ReadKey();

        }
    }
}
