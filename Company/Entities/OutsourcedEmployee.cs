namespace Company.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; protected set; }
        public OutsourcedEmployee (string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment ()
        {
            return base.Payment() + (AdditionalCharge * 1.10);
        }
    }
}
