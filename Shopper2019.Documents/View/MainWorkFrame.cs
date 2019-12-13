using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class MainWorkFrame
    {        //grafika - obszar roboczy dla A4        
        public System.Drawing.Rectangle CreateMainWorkFrame()
        {
            System.Drawing.Rectangle mainFrame = new System.Drawing.Rectangle(15, 15, 760, 1085);
            return mainFrame;
        }

    }
}
