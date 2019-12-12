using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class AmountSplit
    {
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
