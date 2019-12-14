using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public class GroshRecognize
    {
        IContainer container;

        UnitNumberRecognize unitNumberRecognize;
        TeenNumberRecognize teenNumberRecognize;
        TenNumberRecognize tenNumberRecognize;
        EstimateNumberLength estimateNumberLength;

        public GroshRecognize()
        {
            container = DI_Container.Configure();

            unitNumberRecognize = container.Resolve<UnitNumberRecognize>();
            teenNumberRecognize = container.Resolve<TeenNumberRecognize>();
            tenNumberRecognize = container.Resolve<TenNumberRecognize>();
            estimateNumberLength = container.Resolve<EstimateNumberLength>();
        }
        public string GroshRecognizer(string groshOutput, string groshToRecognize, char[] groshDigit)
        {
            switch (estimateNumberLength.CheckNumberLength(groshToRecognize))
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

            return groshOutput;
        }

    }
}
