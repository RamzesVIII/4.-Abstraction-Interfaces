using System;
using System.Collections.Generic;
using System.Text;

namespace Document
{
    class Footer : CommonClass
    {
        public override string Content { get { return content; } set { content = value; } }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
