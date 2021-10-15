using System;

namespace BasicPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("APLIKASI KONVERSI MATA UANG");
            Console.WriteLine("---------------------------");
            Console.WriteLine(" 1 . Rupiah To Dollar");
            Console.WriteLine(" 2 . Dollar To Rupiah");
            Console.WriteLine(" 3 . Keluar");
            Console.WriteLine("---------------------------");
            Console.Write("Pilih Menu 1/2/3  : ");
            int selectedMenu = Convert.ToInt32(Console.ReadLine());

            if (selectedMenu == 1)
            {
                ConvertToUSD();
            }
            else if (selectedMenu == 2)
            {
                ConverToIDR();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        static void ConverToIDR()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("        USD To IDR         ");
            Console.WriteLine("---------------------------");
            Console.Write(" Masukan Nilai USD : $");
            double input = Convert.ToDouble(Console.ReadLine());
            int rupiah = Idr(input);
            Console.WriteLine("---------------------------");
            Console.WriteLine($"${input} = Rp.{rupiah}");
            Console.WriteLine("---------------------------");
            Console.WriteLine(" 1. Ulangi ?");
            Console.WriteLine(" 2. Kembali");
            Console.Write(" Menu : ");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                ConverToIDR();
            }
            else
            {
                Menu();
            }

        }
        static void ConvertToUSD()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("        IDR To USD         ");
            Console.WriteLine("---------------------------");
            Console.Write(" Masukan Nilai IDR : Rp. ");
            double input = Convert.ToDouble(Console.ReadLine());
            double dolar = Usd(input);
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Rp. {input} = ${dolar}");
            Console.WriteLine("---------------------------");
            Console.WriteLine(" 1. Ulangi ?");
            Console.WriteLine(" 2. Kembali");
            Console.Write(" Menu : ");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                ConvertToUSD();
            }
            else
            {
                Menu();
            }
        }
        static int Idr(double nominal)
        {
            double hasil = nominal * 14500;
            return Convert.ToInt32(hasil);
        }
        static double Usd(double nominal)
        {
            double hasil = nominal / 14500;
            return Math.Round(hasil, 2);
        }

    }
}

