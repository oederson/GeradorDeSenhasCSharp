using System.Text;

namespace GeradorDeSenhasCSharp.Models
{
    public class Senha
    {
        private Dictionary<string, string> caracteresPossiveis;

        public Senha(Dictionary<string, string> characterSets)
        {
            caracteresPossiveis = characterSets;
        }
        public  string GerarSenha(int maiusculas, 
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

        private static void AdicionarCaracteresParaSenha(StringBuilder senha, string tipoDeCaracter, int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                char randomCaracter = tipoDeCaracter[random.Next(0, tipoDeCaracter.Length)];
                senha.Append(randomCaracter);
            }
        }

        private static string Misturar(string str)
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
    }
}