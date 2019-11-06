using System;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Document mydocument = new Document("Резюме");

            mydocument.Body = "Тело резюме";
            mydocument.Footer = "Футер резюме";

            mydocument.Show();
        }
    }
}
