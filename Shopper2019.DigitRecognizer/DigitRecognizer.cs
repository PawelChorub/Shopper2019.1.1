using Autofac;
using System.Linq;

namespace Shopper2019.DigitRecognizer
{
    public class DigitRecognizer
    {
        IContainer container;

        ZlotyRecognize zlotyRecognize;
        GroshRecognize groshRecognize;
        AmountSplit amountSplit;
        ZeroNumberRecognize zeroNumberRecognize;

        public DigitRecognizer()
        {
            container = DI_Container.Configure();

            zlotyRecognize = container.Resolve<ZlotyRecognize>();
            groshRecognize = container.Resolve<GroshRecognize>();
            amountSplit = container.Resolve<AmountSplit>();
            zeroNumberRecognize = container.Resolve<ZeroNumberRecognize>();
        }
        public string Run(string input)
        {
            string groshOutput = "";
            string zlotyOutput = "";
            string zlotyToRecognize = "";
            string groshToRecognize = "";
            string[] splitInput = input.Split(',').ToArray();

            amountSplit.SplitAmountByComma(ref zlotyToRecognize, ref groshToRecognize, splitInput);

            char[] zlotyDigit = zlotyToRecognize.ToCharArray();

            zlotyOutput = zlotyRecognize.ZlotyRecognizer(zlotyOutput, zlotyToRecognize, zlotyDigit);

            char[] groshDigit = groshToRecognize.ToCharArray();

            groshOutput = groshRecognize.GroshRecognizer(groshOutput, groshToRecognize, groshDigit);

            zeroNumberRecognize.ZeroNumberRecognizer(ref groshOutput, ref zlotyOutput, zlotyToRecognize, groshToRecognize);

            return zlotyOutput + " zł. " + groshOutput + " gr.";
        }


    }
}
