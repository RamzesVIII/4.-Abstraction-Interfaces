using System;
using System.Collections.Generic;
using System.Text;

namespace Player
{
    class Player : IPlayable, IRecodable
    {
        public void Pause ()
        {
            Console.WriteLine("Music on pause.");
        }
        public void Stop ()
        {
            Console.WriteLine("Music is stopped.");
        }
        public void Play()
        {
            Console.WriteLine("Music Plays.");
        }
        public void Record ()
        {
            Console.WriteLine("Music is being recorded.");
        }
        string condition;

        public void MakeMusic ()
        {
            do
            {
                string variant = Console.ReadLine();
                condition = variant;
                switch (variant)
                {
                    case "play":
                        Play();
                        break;
                    case "record":
                        Record();
                        break;
                    case "pause":
                        Pause();
                        break;
                    case "stop":
                        Stop();
                        break;
                    default:
                        break;
                        
                }
            } while (condition != "exit");
            
        }

        public Player ()
        {
            
        }
    }
}
