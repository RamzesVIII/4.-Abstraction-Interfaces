using System;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие : play, record, pause, stop или exit для выхода.");
            Player myplayer = new Player();
            myplayer.MakeMusic();
        }
    }
}
