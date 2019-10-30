using System;
using System.Collections.Generic;
using System.Text;

namespace Player
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
}
