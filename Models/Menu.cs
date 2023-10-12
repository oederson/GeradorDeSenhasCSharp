namespace GeradorDeSenhasCSharp.Models
{
    public class Menu
    {
        public static void ExibirMenu()
        {
            Senha senha = new();
            var entradas = new Dictionary<string, int>()
            {
                {"Maiúsculas",0},
                {"Minúsculas",0},
                {"Números",0},
                {"Especiais",0}
            };

            Console.WriteLine(@"
█████▀████████████████████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█▄─▄▄─█▄─▄▄▀██▀▄─██▄─▄▄▀█─▄▄─█▄─▄▄▀███▄─▄▄▀█▄─▄▄─███─▄▄▄▄█▄─▄▄─█▄─▀█▄─▄█─█─██▀▄─██─▄▄▄▄█
█─██▄─██─▄█▀██─▄─▄██─▀─███─██─█─██─██─▄─▄████─██─██─▄█▀███▄▄▄▄─██─▄█▀██─█▄▀─██─▄─██─▀─██▄▄▄▄─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▄▀▄▀▄▄▀▄▄▀▄▄▄▄▄▀");
            Console.WriteLine("");
            Console.WriteLine("Bem-vindo ao Gerador de Senhas!");
            Console.WriteLine("");
            Console.WriteLine("Para cada tipo de caracter digite a quantidade que deseja");
            Console.WriteLine("");
            foreach(var entrada in entradas)
            {
                Console.Write($"{entrada.Key} : ");
                string oQueDigitou = Console.ReadLine();
                if (int.TryParse(oQueDigitou, out int quantidade))
                {
                    entradas[entrada.Key] = quantidade;
                }
                else
                {
                    Console.WriteLine("Voce não digitou um número valido a quantidade será 0");
                }
            }

            string senhaGerada = senha.GerarSenha(entradas["Maiúsculas"], 
                                                   entradas["Minúsculas"], 
                                                   entradas["Números"], 
                                                   entradas["Especiais"]);
             Console.WriteLine("");
             Console.WriteLine($"Sua senha gerada com {entradas["Maiúsculas"]} Maiúsculas , {entradas["Minúsculas"]} Minúsculas, {entradas["Números"]} Números, {entradas["Especiais"]} Especiais é : {senhaGerada} ");
        }           
    }
}