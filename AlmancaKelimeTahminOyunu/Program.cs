using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AlmancaKelimeTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("☻ Almanca Kelime Okunuşlarını Tahmin Etme Oyununa Hoş Geldiniiiiiiiiz ☻ ");
            Console.Read();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bu Oyunda Her Bir Oyuncu Verilen Almanca Kelimeleri Okumaya Çalıştıktan Sonra Nasıl Okunduğunu Dinleyeceksiniz.");
            Console.WriteLine("Kelimeyi Görmek ve Daha Sonrasında Dinlemek İçin Enter Tuşuna Basınız. ");
            Console.WriteLine("Keyifli Oyunlar Dileriiiiiz ♥\n");
            Console.ReadKey();

            for (int i = 1; i < 6; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write((i) + ".Kelime: ");


                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Das Huhn = Tavuk ♣\n ");
                    Console.ReadKey();

                    System.Diagnostics.Process.Start("Das-Huhn.mp3");
                    Console.ReadKey();
                }

                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Der Drachen = Ejderha ♣\n ");
                    Console.ReadKey();

                    System.Diagnostics.Process.Start("Der-Drachen.mp3");
                    Console.ReadKey();
                }

                if (i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Der Eisbär = Kutup Ayısı ♣\n ");
                    Console.ReadKey();

                    System.Diagnostics.Process.Start("Der-Eisbär.mp3");
                    Console.ReadKey();
                }

                if (i == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Der Vogel = Kuş ♣\n");
                    Console.ReadKey();

                    System.Diagnostics.Process.Start("Der Vogel.mp3");
                    Console.ReadKey();
                }
                if (i == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Die Katze = Kedi ♣\n");
                    Console.ReadKey();

                    System.Diagnostics.Process.Start("Die Katze.mp3");
                    Console.ReadKey();
                }

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hem Eğlenip Hem Öğrenmeye Devaaaaam ☺\n");
            Console.Read();
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
