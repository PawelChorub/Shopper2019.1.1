using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopper2019.Documents.View
{
    public class MainWorkFrame
    {        
        //grafika - obszar roboczy dla A4        
        public Rectangle CreateMainWorkFrame()
        {
            Rectangle mainFrame = new Rectangle(15, 15, 760, 1085);
            return mainFrame;
        }

    }
}
