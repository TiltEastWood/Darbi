using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    internal interface Car
    {
        
        void SpeedUp();
        
        void SlowDown();
        void StartEngine();
        string ShowCurrentSpeed();

    }
}
