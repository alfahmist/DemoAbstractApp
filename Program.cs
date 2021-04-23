using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstractApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            Pertambahan pertambahan = new Pertambahan(10, 5);
            Console.WriteLine($"Pertambahan {pertambahan.A} + {pertambahan.B} : " + pertambahan.Proccess());
            pertambahan.Display();
            Console.WriteLine();

            Pengurangan pengurangan = new Pengurangan(8, 5);
            Console.WriteLine($"Pertambahan {pengurangan.A} - {pengurangan.A} : " + pengurangan.Proccess());
            pengurangan.Display();
            Console.WriteLine();

            Perkalian perkalian = new Perkalian(4, 5);
            Console.WriteLine($"Pertambahan {perkalian.A} * {perkalian.B} : " + perkalian.Proccess());
            perkalian.Display();
            Console.WriteLine();

            Pembagian pembagian = new Pembagian(50, 10);
            Console.WriteLine($"Pembagian {pembagian.A} / {pembagian.B} : " + pembagian.Proccess());
            perkalian.Display();
            Console.WriteLine();

            Console.Read();

        }

    }

    

}
