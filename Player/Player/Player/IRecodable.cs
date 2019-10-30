using System;
using System.Collections.Generic;
using System.Text;

namespace Player
{
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
