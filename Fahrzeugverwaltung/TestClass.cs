using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugverwaltung
{
    class TestClass
    {
        public void Test()
        {
            //Console.WriteLine("Der Test beginnt...");
            Fahrzeug A3 = new PKW("audi", "a3", "Dfjsg", 34, 23354, true, 34, 234, 1);
            Fahrzeug Scania12 = new LKW("Scania", "12", "ASFh", 1241, 342, true, 6, 21);
            Fahrzeug Kawa23 = new Motorrad("Kawasaki", "K12", "asdf", 324, 123, true, 34);

            A3.berechneSteuer();
            Scania12.berechneSteuer();
            Kawa23.berechneSteuer();
            //Console.ReadLine("Der Test endet...");
        }
    }
}
