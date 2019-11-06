using System;
using System.Collections.Generic;
using System.Text;

namespace Document
{
    abstract class CommonClass
    {
        protected string content;

        abstract public string Content
        { get; set; }
        abstract public void Show();
    }
}
