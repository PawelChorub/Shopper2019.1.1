using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class ZeroNumberRecognize
    {
        public void ZeroNumberRecognizer(ref string groshOutput, ref string zlotyOutput, string zlotyToRecognize, string groshToRecognize)
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
    }
}
