using System;

namespace Dictionary.Entitis
{
    public class Candidatos
    {
        public string Nome { get; set; }
        public int Votos { get; set; }

        public Candidatos(string nome, int votos)
        {
            Nome = nome;
            Votos = votos;
        }


    }
}