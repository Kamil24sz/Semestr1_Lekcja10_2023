using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Semestr1_Lekcja10_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //przypomnienie FOR

            //wypisz liczby od 1 do 10 za pomocą pętli for

            for(int x = 50; x >= 1; x = x - 2)
            {
                Console.WriteLine(x);
            }

            Console.Clear();

            //powoduje wydanie dźwięku przez konsolę
            //1 parametr częstotliwość dźwięku w hercach (hz)
            //w parametr jak długo dźwięk ma być odtworzony (ms)

            for(int x = 100; x <= 10000; x = x + 100)
            {
                Console.Beep(x, 200);
                Console.WriteLine($"Teraz odtwarzam dźwięk o częstotliwości {x}");
            }

            int czestotliwosc = 100;
            while (czestotliwosc <= 10000)  //wykonuje się dopóki wyrażenie logiczne ma wartość true (prawda)
            {
                Console.Beep(czestotliwosc, 200);
                Console.WriteLine($"Teraz odtwarzam dźwięk o częstotliwości {czestotliwosc}");
                czestotliwosc = czestotliwosc + 100;
            }



            Console.ReadLine();
        }
    }
}
