using System;

namespace PRG2_20192_P1_3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;

            Console.WriteLine("Program Syair Lagu Anak Ayam");
            Console.WriteLine("----------------------------");
            /* Inputan Angka dari User */
            Console.Write("Input Angka N : ");
            Num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nANAK AYAM TURUN {0} \n", Num);
            for (int i=Num; i >= 1; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine("Anak Ayam turun {0}, mati satu tinggal Induknya", i);
                }
                else
                {
                    Console.WriteLine("Anak Ayam turun {0}, mati satu tinggal {1}", i, i - 1);
                }
            }
        }
    }
}
