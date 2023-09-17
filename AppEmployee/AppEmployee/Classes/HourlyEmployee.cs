namespace AppEmployee.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public decimal HourVal { get; set; }

        public int KHours { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee() { }

        public override decimal GetValueToPay()
        {
            return HourVal * KHours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Valor a Pagar: {HourVal * KHours:C2}\n\t";
        }

        #endregion
    }
}