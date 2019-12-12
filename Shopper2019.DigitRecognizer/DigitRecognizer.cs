using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class DigitRecognizer
    {
        UnitNumberRecognize unitNumberRecognize = new UnitNumberRecognize();
        public string EstimateTheNumberLength(string input)
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
        //---------------------------------------------------
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
        public string TousandsNumberRecognizer(char input)
        {
            string endings = "";
            string output = "";
            Int32.TryParse(input.ToString(), out int x);
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
                default:
                    output = "";
                    break;
            }
            if (x == 1) endings = "ąc";
            if (x > 1 && x < 5) endings = "ące";
            if (x >= 5 && x <= 9) endings = "ęcy";

            return output + " tysi" + endings;

        }
        //---------------------------------------------------
        public string Run(string input)
        {
            string groshOutput = "";
            string zlotyOutput = "";
            string zlotyToRecognize = "";
            string groshToRecognize = "";
            string[] splitInput = input.Split(',').ToArray();

            //podziel kwotę na 2 części
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

            char[] zlotyDigit = zlotyToRecognize.ToCharArray();

            switch (EstimateTheNumberLength(zlotyToRecognize))
            {
                case "1":
                    zlotyOutput = unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[0]);
                    break;
                case "2":
                    if (zlotyDigit[0] == '1') // 1x,xx
                    {
                        zlotyOutput = TeensNumberRecognizer(zlotyDigit[1]);
                    }
                    else
                    {
                        zlotyOutput = TensNumberRecognizer(zlotyDigit[0]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[1]);
                    }
                    break;
                case "3":
                    if (zlotyDigit[1] == '1') // jeżeli jest jedynka na x1x,xx będzie nastka
                    {
                        zlotyOutput = HundredsNumberRecognizer(zlotyDigit[0]) + " " + TeensNumberRecognizer(zlotyDigit[2]);
                    }
                    else
                    {
                        zlotyOutput = HundredsNumberRecognizer(zlotyDigit[0]) + " " + TensNumberRecognizer(zlotyDigit[1]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[2]);
                    }
                    break;
                case "4":
                    if (zlotyDigit[2] == '1') //x.x1x,xx
                    {
                        zlotyOutput = TousandsNumberRecognizer(zlotyDigit[0]) + " " + HundredsNumberRecognizer(zlotyDigit[1]) + " " + TeensNumberRecognizer(zlotyDigit[3]);
                    }
                    else
                    {
                        zlotyOutput = TousandsNumberRecognizer(zlotyDigit[0]) + " " + HundredsNumberRecognizer(zlotyDigit[1]) + " " + TensNumberRecognizer(zlotyDigit[2]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[3]);
                    }
                    break;
                case "5":
                    if (zlotyDigit[0] == '1' && zlotyDigit[3] == '1') //1x.x1x,xx
                    {
                        zlotyOutput = TeensNumberRecognizer(zlotyDigit[1]) + " tys. " + HundredsNumberRecognizer(zlotyDigit[2]) + " " + TeensNumberRecognizer(zlotyDigit[4]);
                    }
                    else if (zlotyDigit[0] == '1') //1x.xxx,xx
                    {
                        zlotyOutput = TeensNumberRecognizer(zlotyDigit[1]) + " tys. " + HundredsNumberRecognizer(zlotyDigit[2]) + " " + TensNumberRecognizer(zlotyDigit[3]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[4]);
                    }
                    // xx.x1x,xx
                    else if (zlotyDigit[3] == '1')
                    {
                        zlotyOutput = TensNumberRecognizer(zlotyDigit[0]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[1]) + " " + HundredsNumberRecognizer(zlotyDigit[2]) + " " + TeensNumberRecognizer(zlotyDigit[4]);
                    }
                    //xx.xxx,xx
                    else
                    {
                        zlotyOutput = TensNumberRecognizer(zlotyDigit[0]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[1]) + " tys " + HundredsNumberRecognizer(zlotyDigit[2]) + " " + TensNumberRecognizer(zlotyDigit[3]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[4]);
                    }
                    break;
                case "6":
                    if (zlotyDigit[1] == '1' && zlotyDigit[4] == '1') //x1x.x1x,xx
                    {
                        zlotyOutput = HundredsNumberRecognizer(zlotyDigit[0]) + " " + TeensNumberRecognizer(zlotyDigit[2]) + " tys " + HundredsNumberRecognizer(zlotyDigit[3]) + " " + TeensNumberRecognizer(zlotyDigit[5]);
                    }
                    else if (zlotyDigit[1] == '1') //x1x.xxx,xx
                    {
                        zlotyOutput = HundredsNumberRecognizer(zlotyDigit[0]) + " " + TeensNumberRecognizer(zlotyDigit[2]) + " tys * " + HundredsNumberRecognizer(zlotyDigit[3]) + " * " + TensNumberRecognizer(zlotyDigit[4]) + " * " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[5]);
                    }
                    // xxx.x1x,xx
                    else if (zlotyDigit[4] == '1')
                    {
                        zlotyOutput = HundredsNumberRecognizer(zlotyDigit[0]) + " " + TensNumberRecognizer(zlotyDigit[1]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[2]) + " " + HundredsNumberRecognizer(zlotyDigit[3]) + " " + TeensNumberRecognizer(zlotyDigit[5]);
                    }
                    //xx.xxx,xx
                    else
                    {
                        zlotyOutput = HundredsNumberRecognizer(zlotyDigit[0]) + " " + TensNumberRecognizer(zlotyDigit[1]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[2]) + " tys " + HundredsNumberRecognizer(zlotyDigit[3]) + " " + TensNumberRecognizer(zlotyDigit[4]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[5]);
                    }
                    break;
                default:
                    break;
            }

            char[] groshDigit = groshToRecognize.ToCharArray();

            switch (EstimateTheNumberLength(groshToRecognize))
            {
                case "1":
                    groshOutput = unitNumberRecognize.UnitsNumberRecognizer(groshDigit[0]);
                    break;
                case "2":
                    if (groshDigit[0] == '1') // 1x,xx
                    {
                        groshOutput = TeensNumberRecognizer(groshDigit[1]);
                    }
                    else
                    {
                        groshOutput = TensNumberRecognizer(groshDigit[0]) + " " + unitNumberRecognize.UnitsNumberRecognizer(groshDigit[1]);
                    }
                    break;
            }

            if (zlotyToRecognize.Length == 1 && zlotyToRecognize == "0")
            {
                zlotyOutput = "zero";
            }
            if (groshToRecognize == "00")
            {
                groshOutput = "zero";
            }

            return zlotyOutput + " zł. " + groshOutput + " gr.";
        }


    }
}
