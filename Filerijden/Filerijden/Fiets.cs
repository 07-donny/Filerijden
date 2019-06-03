using System;
using System.Collections.Generic;
using System.Text;

namespace Filerijden
{
    class Fiets : Voertuig
    {
        public bool IsElektrisch { get; set; }

         public override void ToonGegevens()
        {
            Console.WriteLine("Type Voertuig: Fiets");
            Console.WriteLine(IsElektrisch);
        }
    }
}
