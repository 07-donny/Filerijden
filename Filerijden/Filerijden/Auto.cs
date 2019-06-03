using System;
using System.Collections.Generic;
using System.Text;

namespace Filerijden
{
    class Auto : Voertuig
    {
        enum Brandstoftype { benzine, diesel, LPG, elektrisch}
        public override void ToonGegevens()
        {
            Console.WriteLine("Type Voertuig: Auto");
            Console.WriteLine(Brandstoftype);
        }
    }
}
