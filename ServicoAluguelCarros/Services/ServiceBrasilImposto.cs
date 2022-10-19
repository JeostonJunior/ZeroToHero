namespace ServicoAluguelCarros.Services
{
    public class ServiceBrasilImposto : IServiceImposto
    {
        public double Imposto (double valor)
        {
            if (valor <= 100.00)
            {
                return valor * 0.2;
            }
            return valor * 0.15;
        }
    }
}
