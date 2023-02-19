using VATCalculator.Logic.Abstractions;
using VATCalculator.Logic.Helpers;

namespace VATCalculator.Logic.Models
{
    public class VATCalculatorInfo : ICalculatorInfo
    {
        public decimal Tax { get; set; }

        public decimal? NetAmount { get; set; }

        public decimal? VATAmount { get; set; }

        public decimal? GrossAmount { get; set; }

        public void FillInfo()
        {
            if (NetAmount is not null)
            {
                VATAmount = LogicCalculator.VATAmountCalculatorWithNetAmount(
                                                Tax, 
                                                NetAmount.Value
                                            );

                GrossAmount = LogicCalculator.GrossAmountWithNetAmountAndVATAmount(
                                                NetAmount.Value, 
                                                VATAmount.Value
                                            );
            }
            else if(VATAmount is not null)
            {
                NetAmount = LogicCalculator.NetAmountCalculatorWithVATAmount(
                                                Tax,
                                                VATAmount.Value
                                            );

                GrossAmount = LogicCalculator.GrossAmountWithNetAmountAndVATAmount(
                                               NetAmount.Value,
                                               VATAmount.Value
                                           );
            }
            else if(GrossAmount is not null)
            {
                NetAmount = LogicCalculator.NetAmountCalculatorWithGrossAmount(
                                                Tax,
                                                GrossAmount.Value
                                            );

                VATAmount = LogicCalculator.VATAmountWithNetAmountAndGrossAmount(
                                                GrossAmount.Value,
                                                NetAmount.Value
                                            );
            }

        }
    }
}
