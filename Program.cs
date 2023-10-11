using GeradorDeSenhasCSharp.Models;

Console.WriteLine(@"
█████▀████████████████████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█▄─▄▄─█▄─▄▄▀██▀▄─██▄─▄▄▀█─▄▄─█▄─▄▄▀███▄─▄▄▀█▄─▄▄─███─▄▄▄▄█▄─▄▄─█▄─▀█▄─▄█─█─██▀▄─██─▄▄▄▄█
█─██▄─██─▄█▀██─▄─▄██─▀─███─██─█─██─██─▄─▄████─██─██─▄█▀███▄▄▄▄─██─▄█▀██─█▄▀─██─▄─██─▀─██▄▄▄▄─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▄▄▀▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▄▀▄▀▄▄▀▄▄▀▄▄▄▄▄▀");

var caracteresPossiveis = new Dictionary<string, string>();
    caracteresPossiveis.Add("Maiusculas", "ABCDEFGHIJLMNOPQRSTUVXZ");
    caracteresPossiveis.Add("Minusculas", "abcdefghijlmnopqrstuvxz");
    caracteresPossiveis.Add("Numeros", "1234567890");
    caracteresPossiveis.Add("Especiais", "%$#@!");

Console.Write("Digite a quantidade de maiúsculas: ");
    int maiusculas = int.Parse(Console.ReadLine());
        
Console.Write("Digite a quantidade de minúsculas: ");
    int minusculas = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de números: ");
    int numeros = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de caracteres especiais: ");
    int especiais = int.Parse(Console.ReadLine());

var senha = new Senha(caracteresPossiveis);
string senhaGerada = senha.GerarSenha(maiusculas, minusculas, numeros, especiais, caracteresPossiveis);
Console.WriteLine($"Sua senha gerada com {maiusculas} maiusculas,{minusculas} minusculas, {numeros} numeros, {especiais} especiais é : {senhaGerada} ");
