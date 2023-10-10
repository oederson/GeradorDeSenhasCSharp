﻿using System.Text;
    
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


int tamanhoTotalDaSenha = maiusculas + minusculas + numeros + especiais; 
string senha = GerarSenha(maiusculas, minusculas, numeros, especiais, caracteresPossiveis);
    Console.WriteLine($"Sua senha gerada com {maiusculas} maiusculas,{minusculas} minusculas, {numeros} numeros, {especiais} especiais é : " + senha);
    

static string GerarSenha(int maiusculas, 
                         int minusculas, 
                         int numeros, 
                         int especiais, 
                         Dictionary<string, string> caracteres)
    {
        var random = new Random();
        var senha = new StringBuilder();

        // Gere maiúsculas
        AdicionarCaracteresParaSenha(senha, caracteres["Maiusculas"], maiusculas, random);

        // Gere minúsculas
        AdicionarCaracteresParaSenha(senha, caracteres["Minusculas"], minusculas, random);

        // Gere números
        AdicionarCaracteresParaSenha(senha, caracteres["Numeros"], numeros, random);

        // Gere caracteres especiais
        AdicionarCaracteresParaSenha(senha, caracteres["Especiais"], especiais, random);

        // Embaralhe a senha
        return Misturar(senha.ToString());
    }

    static void AdicionarCaracteresParaSenha(StringBuilder senha, string tipoDeCaracter, int count, Random random)
    {
        for (int i = 0; i < count; i++)
        {
            char randomCaracter = tipoDeCaracter[random.Next(0, tipoDeCaracter.Length)];
            senha.Append(randomCaracter);
        }
    }

    static string Misturar(string str)
    {
        char[] caracteres = str.ToCharArray();
        Random random = new Random();

        for (int i = caracteres.Length - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            char temp = caracteres[i];
            caracteres[i] = caracteres[j];
            caracteres[j] = temp;
        }

        return new string(caracteres);
    }

