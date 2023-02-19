namespace VATCalculator.Logic.Abstractions
{
    public interface ICalculatorInfo
    {
        decimal Tax { get; set; }

        decimal? NetAmount { get; set; }

        decimal? VATAmount { get; set; }

        decimal? GrossAmount { get; set; }

        void FillInfo();
    }
}
