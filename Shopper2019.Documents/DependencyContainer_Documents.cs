 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents
{
    public class DependencyContainer_Documents
    {
        public static IBusinessLogic_Documents BusinessLogic_DocumentsInject()
        {
            return new BusinessLogic_Documents();
        }
    }
}
