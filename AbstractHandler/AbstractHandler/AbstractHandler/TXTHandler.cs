using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHandler
{
    class TXTHandler : AbstractHandler
    {
        private string format;

        public TXTHandler(string format) : base(format)
        {
            this.format = format;
        }

        public override void Open()
        {
            Console.WriteLine("{0} document was opened", format);
        }
        public override void Create()
        {
            Console.WriteLine("{0} document was createded", format);
        }
        public override void Change()
        {
            Console.WriteLine("{0} document was changed", format);
        }
        public override void Save()
        {
            Console.WriteLine("{0} document was Saved", format);
        }
    }
}
