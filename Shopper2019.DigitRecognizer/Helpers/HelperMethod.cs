using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer.Helpers
{
    public class HelperMethod
    {
        public void ZeroNumberRecognize(ref string groshOutput, ref string zlotyOutput, string zlotyToRecognize, string groshToRecognize)
        {
            if (zlotyToRecognize.Length == 1 && zlotyToRecognize == "0")
            {
                zlotyOutput = "zero";
            }
            if (groshToRecognize == "00")
            {
                groshOutput = "zero";
            }
        }

        public void SplitAmountByComma(ref string zlotyToRecognize, ref string groshToRecognize, string[] splitInput)
        {
            for (int i = 0; i < splitInput.Length; i++)
            {
                // XXXX,xx
                if (i == splitInput.Length - 2)
                {
                    zlotyToRecognize += splitInput[i];
                }
                //xxxx,XX
                else
                {
                    groshToRecognize += splitInput[i];
                }
            }
        }

    }
}
