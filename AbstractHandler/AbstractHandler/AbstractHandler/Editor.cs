using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHandler
{
    class Editor
    {
        private string field;

        public string Field
        { get { return field; }
          set { field = value; }
        }

       public Editor ()
        {
            Console.WriteLine("Choose document format : txt, doc, xml");
            Field = Console.ReadLine();
        }

        public void chooseformat ()
        {
            
            switch (field)
            {
                case "txt":
                    AbstractHandler txtinstance = new TXTHandler("txt");
                    txtinstance.Create();
                    txtinstance.Open();
                    txtinstance.Change();
                    txtinstance.Save();
                    break;
                case "doc":
                    DOCHandler docinstance = new DOCHandler("doc");
                    docinstance.Create();
                    docinstance.Open();
                    docinstance.Change();
                    docinstance.Save();
                    break;
                case "xml":
                    XMLHandler xmlinstance = new XMLHandler("xml");
                    xmlinstance.Create();
                    xmlinstance.Open();
                    xmlinstance.Change();
                    xmlinstance.Save();
                    break;
                default:
                    break;
            }
        }
    }
}
