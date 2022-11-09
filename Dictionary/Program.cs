using System;
using System.IO;
using System.Globalization;
using Dictionary.Entitis;

namespace Dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"./urnas.txt";
            string nomeDiretorio = Path.GetDirectoryName(path);
            string diretorioFinal = nomeDiretorio + @"\out";
            string nomeArquivo = diretorioFinal + @"\totalUrnas.txt";

            try
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] separador = sr.ReadLine().Split(",");
                        string candidato = separador[0];
                        int votos = int.Parse(separador[1]);

                        if (dictionary.ContainsKey(candidato))
                        {
                            dictionary[candidato] += votos;
                        }
                        else
                        {
                            dictionary[candidato] = votos;
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(nomeArquivo))
                {
                    foreach (var candidato in dictionary)
                    {
                        sw.WriteLine($"{candidato.Key} | {candidato.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}
