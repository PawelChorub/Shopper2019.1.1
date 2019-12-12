using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class EstimateNumberLength
    {
        public string CheckNumberLength(string input)
        {
            string output = "";
            int length = input.Length;
            switch (length)
            {
                case 1:
                    output = "1";
                    break;
                case 2:
                    output = "2";
                    break;
                case 3:
                    output = "3";
                    break;
                case 4:
                    output = "4";
                    break;
                case 5:
                    output = "5";
                    break;
                case 6:
                    output = "6";
                    break;
                default:
                    output = "0";
                    break;
            }
            return output;
        }

    }
}
