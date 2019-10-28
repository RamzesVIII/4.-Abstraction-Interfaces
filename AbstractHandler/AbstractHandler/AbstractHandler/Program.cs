using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Editor newdocument = new Editor();
            newdocument.chooseformat();
        }
    }
}
