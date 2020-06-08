using System;

namespace Bot.Instagram.Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o perfil do insta a ser buscado:");
            var nomePerfil = Console.ReadLine();

            if (string.IsNullOrEmpty(nomePerfil))
                nomePerfil = "netogan";

            var profile = Models.Instagram.GetProfileByUser(nomePerfil);

            Console.WriteLine($"UserName: {profile.UserName}");
            Console.WriteLine($"Title: {profile.Title}");
            Console.WriteLine($"Description: {profile.Description}");
            Console.WriteLine($"Url: {profile.Url}");
            Console.WriteLine($"Image: {profile.Imagem}");
            Console.WriteLine($"AndroidAppId: {profile.AndroidAppId}");
            Console.WriteLine($"AndroidAppName: {profile.AndroidAppName}");
            Console.WriteLine($"AndroidUrl: {profile.AndroidUrl}");
            Console.WriteLine($"IosAppId: {profile.IosAppId}");
            Console.WriteLine($"IosAppName: {profile.IosAppName}");
            Console.WriteLine($"IosUrl: {profile.IosUrl}");

            Console.ReadKey();
        }
    }
}
