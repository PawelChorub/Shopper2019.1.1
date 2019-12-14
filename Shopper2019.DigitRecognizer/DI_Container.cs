using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.DigitRecognizer
{
    public static class DI_Container
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UnitNumberRecognize>().AsSelf();
            builder.RegisterType<TeenNumberRecognize>().AsSelf();
            builder.RegisterType<TenNumberRecognize>().AsSelf();
            builder.RegisterType<EstimateNumberLength>().AsSelf();
            builder.RegisterType<HundredNumerRecognize>().AsSelf();
            builder.RegisterType<TousandNumberRecognize>().AsSelf();
            builder.RegisterType<ZlotyRecognize>().AsSelf();
            builder.RegisterType<GroshRecognize>().AsSelf();
            builder.RegisterType<AmountSplit>().AsSelf();
            builder.RegisterType<ZeroNumberRecognize>().AsSelf();

            return builder.Build();
        }
    }
}
