namespace VATCalculator.Logic.Helpers
{
    public static class LogicCalculator
    {
        public static decimal VATAmountCalculatorWithNetAmount(decimal tax, decimal netAmount)
        {
            return netAmount * (tax / 100);
        }

        public static decimal NetAmountCalculatorWithVATAmount(decimal tax, decimal VATAmount)
        {
            return VATAmount * (100 / tax);
        }

        public static decimal NetAmountCalculatorWithGrossAmount(decimal tax, decimal grossAmount)
        {
            return grossAmount / (tax / 100);
        }

        public static decimal GrossAmountWithNetAmountAndVATAmount(decimal grossAmount, decimal VATAmount)
        {
            return grossAmount + VATAmount;
        }

        public static decimal VATAmountWithNetAmountAndGrossAmount(decimal grossAmount, decimal netAmount)
        {
            return grossAmount - netAmount;
        }
    }
}
