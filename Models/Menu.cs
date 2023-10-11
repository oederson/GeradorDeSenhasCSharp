using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeSenhasCSharp.Models
{
    public class Menu
    {
        public static void ExibirMenu()
        {
            Console.WriteLine(@"
█████▀████████████████████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█▄─▄▄─█▄─▄▄▀██▀▄─██▄─▄▄▀█─▄▄─█▄─▄▄▀███▄─▄▄▀█▄─▄▄─███─▄▄▄▄█▄─▄▄─█▄─▀█▄─▄█─█─██▀▄─██─▄▄▄▄█
█─██▄─██─▄█▀██─▄─▄██─▀─███─██─█─██─██─▄─▄████─██─██─▄█▀███▄▄▄▄─██─▄█▀██─█▄▀─██─▄─██─▀─██▄▄▄▄─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▄▀▄▀▄▄▀▄▄▀▄▄▄▄▄▀");
            Console.WriteLine("Bem-vindo ao Gerador de Senhas!");

            var caracteresPossiveis = new Dictionary<string, string>();
            caracteresPossiveis.Add("Maiusculas", "ABCDEFGHIJLMNOPQRSTUVXZ");
            caracteresPossiveis.Add("Minusculas", "abcdefghijlmnopqrstuvxz");
            caracteresPossiveis.Add("Numeros", "1234567890");
            caracteresPossiveis.Add("Especiais", "%$#@!");

            Console.WriteLine("");
            Console.WriteLine("Digite a quantidade de cada tipo de caractere desejado:");
            Console.Write("Maiúsculas: ");
            int maiusculas = int.Parse(Console.ReadLine());

            Console.Write("Minúsculas: ");
            int minusculas = int.Parse(Console.ReadLine());

            Console.Write("Números: ");
            int numeros = int.Parse(Console.ReadLine());

            Console.Write("Caracteres Especiais: ");
            int especiais = int.Parse(Console.ReadLine());

            var senha = new Senha(caracteresPossiveis);
            string senhaGerada = senha.GerarSenha(maiusculas, minusculas, numeros, especiais, caracteresPossiveis);
            Console.WriteLine("");
            Console.WriteLine($"Sua senha gerada com {maiusculas} maiusculas,{minusculas} minusculas, {numeros} numeros, {especiais} especiais é : {senhaGerada} ");
        }
        

        
    }
}