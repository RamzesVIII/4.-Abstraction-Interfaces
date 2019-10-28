using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHandler
{
    abstract class AbstractHandler
    {
        private string format;

        public AbstractHandler(string format)
        {
            this.format = format;
        }

        public abstract void Open();

        public abstract void Create();
        
        public abstract void Change ();
        
        public abstract void Save ();
        
    }
}
