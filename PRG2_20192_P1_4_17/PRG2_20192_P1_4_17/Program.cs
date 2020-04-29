using System;

namespace PRG2_20192_P1_4_17
{
    class Program
    {
        static void Main(string[] args)
        {
            char Pilihan;

            // Console.WriteLine("Author : M. Rifqy Herdiyanto");
            Console.WriteLine("\nMENU SEGITIGA SIKU-SIKU\n");
            Console.WriteLine("a. Hitung Luas ");
            Console.WriteLine("b. Hitung Hipotenusa ");
            Console.WriteLine("c. Hitung Keliling" );
            Console.WriteLine("d. Keluar ");

            /* Inputan Menu oleh User */
            Console.Write("\nMenu Pilihan : ");
            Pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("------------------------");
            switch (Pilihan)
            {
                case 'a':
                    HitungLuasSegitiga();
                    break;
                case 'b':
                    HitungHipotenusaSegitiga();
                    break;
                case 'c':
                    HitungKelilingSegitiga();
                    break;
                case'd':
                    Environment.Exit(0);
                    break;
                default: Console.Clear(); Main(null);
                    break;
            }
        }
        static void HitungLuasSegitiga()
        {
            double alas;
            double tinggi;
            double luas;

            Console.WriteLine("\nLUAS SEGITIGA\n");
            Console.Write("Masukkan Alas : ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Tinggi : ");
            tinggi = Convert.ToDouble(Console.ReadLine());

            luas = alas * tinggi / 2;

            Console.WriteLine("Luas segitiga dengan Alas {0} dan Tinggi {1} adalah {2} satuan ", alas, tinggi, luas);
            KonfirmasiProgram();
        }
        static void HitungHipotenusaSegitiga()
        {
            double sisi1;
            double sisi2;
            double Hipotenusa;

            Console.WriteLine("\nHIPOTENUSA SEGITIGA\n");
            Console.Write("Masukkan Sisi Pertama : ");
            sisi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Sisi Kedua   : ");
            sisi2 = Convert.ToDouble(Console.ReadLine());

            Hipotenusa = Math.Sqrt((sisi1 * sisi1) + (sisi2 * sisi2));
            Console.WriteLine("Hipotenusa Segitiga dengan Sisi {0} dan Sisi {1} adalah {2} satuan ", sisi1, sisi2, Hipotenusa);
            KonfirmasiProgram();
        }
        static void HitungKelilingSegitiga()
        {
            double sisi1;
            double sisi2;
            double Hipotenusa;
            double keliling;

            Console.WriteLine("\nKELILING SEGITIGA\n");
            Console.Write("Masukkan Sisi Pertama : ");
            sisi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Sisi Kedua   : ");
            sisi2 = Convert.ToDouble(Console.ReadLine());

            Hipotenusa = Math.Sqrt((sisi1 * sisi1) + (sisi2 * sisi2));
            keliling = sisi2 + sisi1 + Hipotenusa;

            Console.WriteLine("Keliling Segitiga dengan Sisi {0}, Sisi {1} dan Hipotenusa {2} adalah {3} satuan ", sisi1, sisi2, Hipotenusa, keliling);
            KonfirmasiProgram();
        }
        static void KonfirmasiProgram()
        {
            char Pilihan;

            Console.WriteLine("\n\nProgram Selesai. \n");

            do
            {
                Console.Write("Ingin Melanjutkan Program (y/t): ");
                Pilihan = Convert.ToChar(Console.ReadLine());
                if(Pilihan == 'y' || Pilihan == 't')
                {
                    break;
                }
            } while (true);
            
            if (Pilihan == 'y')
            {
                Console.Clear();
                Main(null);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}