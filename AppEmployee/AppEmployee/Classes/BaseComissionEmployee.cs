namespace AppEmployee.Classes
{
    public class BaseComissionEmployee : ComissionEmployee
    {
        #region Properties

        public decimal Base { get; set; }

        #endregion

        #region Methods

        public BaseComissionEmployee() { }

        public override decimal GetValueToPay()
        {
            return ((ComiPer / 100) * Sales) + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Total a pagar: {((ComiPer / 100) * Sales) + Base:C2}\n\t";
        }

        #endregion
    }
}
