using System;
using System.Collections.Generic;
using System.Text;

namespace Document
{
    class Document
    {
        CommonClass title = null;
        CommonClass body = null;
        CommonClass footer = null;

        void Initialization ()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }

        public Document(string title)
        {
            Initialization();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }
    }
}
