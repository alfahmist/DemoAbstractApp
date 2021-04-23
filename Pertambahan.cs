using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAbstractApp
{
    public class Pertambahan : DemoAbstract
    {
        public Pertambahan(int a, int b)
        {
            A = a;
            B = b;
        }

        public int A { get; private set; }
        public int B { get; private set; }

        public override int Proccess()
        {
            return A + B;
        }
    }
}
