using System.Text;

namespace GeradorDeSenhasCSharp.Models
{
    public class Senha
    {
        private int QuantidadeDeCaracteres { get; set; }
        private string CaracteresPossiveis { get; set; }
        public  string GerarSenha(int maiusculas, 
                         int minusculas, 
                         int numeros, 
                         int especiais
                         )
        {
            Senha[] senhasPossiveis = new Senha[4]
            {
                new(){QuantidadeDeCaracteres = maiusculas, CaracteresPossiveis = "ABCDEFGHIJLMNOPQRSTUVXZ" },
                new(){QuantidadeDeCaracteres = minusculas, CaracteresPossiveis = "abcdefghijlmnopqrstuvxz" },
                new(){QuantidadeDeCaracteres = numeros, CaracteresPossiveis = "1234567890" },
                new(){QuantidadeDeCaracteres = especiais, CaracteresPossiveis = "%$#@!" },
            };

            var senha = new StringBuilder();

            foreach (Senha s in senhasPossiveis)
                {
                    AdicionarCaracteresParaSenha(senha, s.CaracteresPossiveis, s.QuantidadeDeCaracteres);
                }
            return Misturar(senha.ToString());
        }

        private static void AdicionarCaracteresParaSenha(StringBuilder senha, string tipoDeCaracter, int count)
        {
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                char randomCaracter = tipoDeCaracter[random.Next(0, tipoDeCaracter.Length)];
                senha.Append(randomCaracter);
            }
        }

        private static string Misturar(string str)
        {
            char[] caracteres = str.ToCharArray();
            Random random = new ();

            for (int i = caracteres.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                (caracteres[j], caracteres[i]) = (caracteres[i], caracteres[j]);
            }

            return new string(caracteres);
        }
    }
}