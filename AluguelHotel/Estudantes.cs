namespace AluguelHotel
{
    public class Estudantes
    {
        public string Nome { get; set; }
        public string Email { get; private set; }


        public Estudantes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}