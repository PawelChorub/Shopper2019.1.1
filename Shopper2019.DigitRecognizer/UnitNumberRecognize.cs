using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class UnitNumberRecognize
    {
        public string UnitsNumberRecognizer(char input)
        {
            string output = "";

            switch (input)
            {
                case '1':
                    output = "jeden";
                    break;
                case '2':
                    output = "dwa";
                    break;
                case '3':
                    output = "trzy";
                    break;
                case '4':
                    output = "cztery";
                    break;
                case '5':
                    output = "pięć";
                    break;
                case '6':
                    output = "sześć";
                    break;
                case '7':
                    output = "siedem";
                    break;
                case '8':
                    output = "osiem";
                    break;
                case '9':
                    output = "dziewięć";
                    break;
            }
            return output;
        }
    }
}
