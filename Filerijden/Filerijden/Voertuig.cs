using System;
using System.Collections.Generic;
using System.Text;

namespace Filerijden
{
    class Voertuig
    {
        public float Lengte { get; set; }
        public float Gewicht { get; set; }

        public virtual void ToonGegevens()
        {
            Console.WriteLine(Lengte);
            Console.WriteLine(Gewicht);
        }
    }
}
