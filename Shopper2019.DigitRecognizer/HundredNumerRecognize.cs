using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class HundredNumerRecognize
    {
        public string HundredsNumberRecognizer(char input)
        {
            string output = "";

            switch (input)
            {
                case '1':
                    output = "sto";
                    break;
                case '2':
                    output = "dwieście";
                    break;
                case '3':
                    output = "trzysta";
                    break;
                case '4':
                    output = "czterysta";
                    break;
                case '5':
                    output = "pięćset";
                    break;
                case '6':
                    output = "sześćset";
                    break;
                case '7':
                    output = "siedemset";
                    break;
                case '8':
                    output = "osiemset";
                    break;
                case '9':
                    output = "dziewięćset";
                    break;
                default:
                    output = "";
                    break;
            }

            return output;
        }
    }
}
