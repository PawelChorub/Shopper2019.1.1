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
        TeenNumberRecognize teenNumberRecognize = new TeenNumberRecognize();
        TenNumberRecognize tenNumberRecognize = new TenNumberRecognize();
        HundredNumerRecognize hundredNumberRecognize = new HundredNumerRecognize();
        TousandNumberRecognize tousandNumberRecognize = new TousandNumberRecognize();

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
                        zlotyOutput = teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[1]);
                    }
                    else
                    {
                        zlotyOutput = tenNumberRecognize.TensNumberRecognizer(zlotyDigit[0]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[1]);
                    }
                    break;
                case "3":
                    if (zlotyDigit[1] == '1') // jeżeli jest jedynka na x1x,xx będzie nastka
                    {
                        zlotyOutput = hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[0]) + " " + teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[2]);
                    }
                    else
                    {
                        zlotyOutput = hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[0]) + " " + tenNumberRecognize.TensNumberRecognizer(zlotyDigit[1]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[2]);
                    }
                    break;
                case "4":
                    if (zlotyDigit[2] == '1') //x.x1x,xx
                    {
                        zlotyOutput = tousandNumberRecognize.TousandsNumberRecognizer(zlotyDigit[0]) + " " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[1]) + " " + teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[3]);
                    }
                    else
                    {
                        zlotyOutput = tousandNumberRecognize.TousandsNumberRecognizer(zlotyDigit[0]) + " " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[1]) + " " + tenNumberRecognize.TensNumberRecognizer(zlotyDigit[2]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[3]);
                    }
                    break;
                case "5":
                    if (zlotyDigit[0] == '1' && zlotyDigit[3] == '1') //1x.x1x,xx
                    {
                        zlotyOutput = teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[1]) + " tys. " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[2]) + " " + teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[4]);
                    }
                    else if (zlotyDigit[0] == '1') //1x.xxx,xx
                    {
                        zlotyOutput = teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[1]) + " tys. " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[2]) + " " + tenNumberRecognize.TensNumberRecognizer(zlotyDigit[3]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[4]);
                    }
                    // xx.x1x,xx
                    else if (zlotyDigit[3] == '1')
                    {
                        zlotyOutput = tenNumberRecognize.TensNumberRecognizer(zlotyDigit[0]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[1]) + " " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[2]) + " " + teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[4]);
                    }
                    //xx.xxx,xx
                    else
                    {
                        zlotyOutput = tenNumberRecognize.TensNumberRecognizer(zlotyDigit[0]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[1]) + " tys " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[2]) + " " + tenNumberRecognize.TensNumberRecognizer(zlotyDigit[3]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[4]);
                    }
                    break;
                case "6":
                    if (zlotyDigit[1] == '1' && zlotyDigit[4] == '1') //x1x.x1x,xx
                    {
                        zlotyOutput = hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[0]) + " " + teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[2]) + " tys " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[3]) + " " + teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[5]);
                    }
                    else if (zlotyDigit[1] == '1') //x1x.xxx,xx
                    {
                        zlotyOutput = hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[0]) + " " + teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[2]) + " tys * " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[3]) + " * " + tenNumberRecognize.TensNumberRecognizer(zlotyDigit[4]) + " * " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[5]);
                    }
                    // xxx.x1x,xx
                    else if (zlotyDigit[4] == '1')
                    {
                        zlotyOutput = hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[0]) + " " + tenNumberRecognize.TensNumberRecognizer(zlotyDigit[1]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[2]) + " " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[3]) + " " + teenNumberRecognize.TeensNumberRecognizer(zlotyDigit[5]);
                    }
                    //xx.xxx,xx
                    else
                    {
                        zlotyOutput = hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[0]) + " " + tenNumberRecognize.TensNumberRecognizer(zlotyDigit[1]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[2]) + " tys " + hundredNumberRecognize.HundredsNumberRecognizer(zlotyDigit[3]) + " " + tenNumberRecognize.TensNumberRecognizer(zlotyDigit[4]) + " " + unitNumberRecognize.UnitsNumberRecognizer(zlotyDigit[5]);
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
                        groshOutput = teenNumberRecognize.TeensNumberRecognizer(groshDigit[1]);
                    }
                    else
                    {
                        groshOutput = tenNumberRecognize.TensNumberRecognizer(groshDigit[0]) + " " + unitNumberRecognize.UnitsNumberRecognizer(groshDigit[1]);
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
