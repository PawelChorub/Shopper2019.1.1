using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class TeenNumberRecognize
    {
        public string TeensNumberRecognizer(char input)
        {
            //wyjście sterowane jest cyfrą jednostkową
            string output = "";

            switch (input)
            {
                case '0':
                    output = "dziesięć";
                    break;
                case '1':
                    output = "jedenascie";
                    break;
                case '2':
                    output = "dwanaście";
                    break;
                case '3':
                    output = "trzynaście";
                    break;
                case '4':
                    output = "czternaście";
                    break;
                case '5':
                    output = "piętnaście";
                    break;
                case '6':
                    output = "szesnaście";
                    break;
                case '7':
                    output = "siedemnaście";
                    break;
                case '8':
                    output = "osiemnaście";
                    break;
                case '9':
                    output = "dziewiętnaście";
                    break;
                default:
                    output = "";
                    break;
            }
            return output;
        }
    }
}
