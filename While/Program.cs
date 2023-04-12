using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //używając pętli while wypisz wszystkie liczby podzeielne przez 3, od 0 do 1000

            int x = 0;
            while(x < 1000)
            {
                Console.WriteLine(x);
                x = x + 3;
            }

            Console.Clear();

            // napisz program, który wygeneruje klucze cd key w formie xxxxx-xxxxx-xxxxx-xxxxx-xxxxx
            // użyj do tego pętli while wygeneruj 50 różnych kluczy
            Random liczbaLosowa = new Random();
            int y = 1;
            while (y <= 10) {

                string klucz = "";       // pusty klucz do którego dokleimy resztę cyfr
                int dlugoscKlucza = 25;  // ustalamy długość klucza (ilość x)

                int numerZnaku = 0;
                while (numerZnaku < dlugoscKlucza)
                {
                    klucz = klucz + liczbaLosowa.Next(0, 10);   // dodawanie losowych cyfr do cd-keya
                    numerZnaku++;        // zwiększanie zmiennej startowej

                    // dodawnie pauz co 5 miejsc i zabezpiecznie przed dodaniem pauzy na końcu
                    if (numerZnaku % 5 == 0 && numerZnaku != dlugoscKlucza)
                    {
                        klucz = klucz + "-";
                    }
                }
                Console.WriteLine($"Klucz nr {y}: {klucz}"); // wypisanie kompletnego klucza
                y++;
            }
            Console.Clear();

            //pętla do while zawsze wykona sie conajmniej raz niezależnie od warunku
            do
            {
                Console.WriteLine("Test");
            }
            while (false);

            //jeśli warunek będzie wartości true to pętla zachowa się jak zwykły while
            int z = 1;
            do
            {
                Console.WriteLine("Test");
                z++;
            }
            while (z <= 10);


            //break przerywa działanie pętli
            for(int t = 0; t < 10; t++) 
            {
                if(t == 5)
                {
                    break;
                }
                Console.WriteLine($"t = {t}");
            }


            Console.ReadLine();
        }
    }
}
