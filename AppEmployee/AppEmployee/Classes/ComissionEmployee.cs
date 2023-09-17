namespace AppEmployee.Classes
{
    public class ComissionEmployee : Employee
    {
        #region Properties

        public decimal ComiPer { get; set; }

        public decimal Sales { get; set; }

        #endregion

        #region Methods

        public ComissionEmployee() { }

        public override decimal GetValueToPay()
        {
            return (ComiPer / 100) * Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Valor Comisiones: {(ComiPer / 100) * Sales:C2}\n\t";
        }

        #endregion
    }
}
