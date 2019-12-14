using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class ZlotyRecognize
    {
        IContainer container;

        EstimateNumberLength estimateNumberLength;
        UnitNumberRecognize unitNumberRecognize;
        TeenNumberRecognize teenNumberRecognize;
        TenNumberRecognize tenNumberRecognize;
        HundredNumerRecognize hundredNumberRecognize;
        TousandNumberRecognize tousandNumberRecognize;

        public ZlotyRecognize()
        {
            container = DI_Container.Configure();

            estimateNumberLength = container.Resolve<EstimateNumberLength>();
            unitNumberRecognize = container.Resolve<UnitNumberRecognize>();
            teenNumberRecognize = container.Resolve<TeenNumberRecognize>();
            tenNumberRecognize = container.Resolve<TenNumberRecognize>();
            hundredNumberRecognize = container.Resolve<HundredNumerRecognize>();
            tousandNumberRecognize = container.Resolve<TousandNumberRecognize>();
        }

        public string ZlotyRecognizer(string zlotyOutput, string zlotyToRecognize, char[] zlotyDigit)
        {
            switch (estimateNumberLength.CheckNumberLength(zlotyToRecognize))
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

            return zlotyOutput;
        }

    }
}
