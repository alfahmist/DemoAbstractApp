using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstractApp
{
    public abstract class DemoAbstract
    {
        public void Display()
        {
            Console.WriteLine("Perhitungan Selesai");
        }

        public abstract int Proccess();
    }
}
