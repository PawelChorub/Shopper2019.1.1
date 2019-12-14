using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class TenNumberRecognize
    {
        public string TensNumberRecognizer(char input)
        {
            string output = "";

            switch (input)
            {
                case '1':
                    output = "dziesięć";
                    break;
                case '2':
                    output = "dwadzieścia";
                    break;
                case '3':
                    output = "trzydzieści";
                    break;
                case '4':
                    output = "czterdzieści";
                    break;
                case '5':
                    output = "pięćdziesiąt";
                    break;
                case '6':
                    output = "sześćdziesiąt";
                    break;
                case '7':
                    output = "siedemdziesiąt";
                    break;
                case '8':
                    output = "osiemdziesiąt";
                    break;
                case '9':
                    output = "dziewięćdziesiąt";
                    break;
                default:
                    output = "";
                    break;
            }

            return output;
        }
    }
}
