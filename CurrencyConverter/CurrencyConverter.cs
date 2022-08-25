namespace CurrencyConverter
{
    class CurrencyConverter
    {
        public static double IOF = 1.06;

        public static double Convert(double quote, double value)
        {
            double finalValue;
            finalValue = (value * quote) * IOF;
            return finalValue;
        }

    }
}