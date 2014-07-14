using System;
using System.Collections.Generic;

namespace iteratory
{
    class Program
    {
        static void Main()
        {

#region pojemniki

            //var testowa = new List<int> { 3, 7, 1, 67, 9, 12, 34, 5, 2, 0 , 341, 22, 42, 31};

            var testowaStr = new List<string> { "tekst", "znowutekst", "ala", "ma", "kota", "bardzo", "go", "lubi",
            "ale", "tekstowo", "test", "gdzies","alt", "like", "tez"};

            var tabStr = new[] { "tekst", "znowutekst", "ala", "ma", "kota", "bardzo", "go", "lubi",
                "ale", "tekstowo", "test", "gdzies","alt", "like", "tez"};
          
#endregion

            var oIteratorClass = new IteratorClass<string>("t", testowaStr);
            //var oIClass = new IteratorClass<int>(1, testowa);

#region wypisz
            foreach (var item in tabStr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Sortowanie: GetEnumerator() -> alfabetycznie jeśli zaczyna się na t");
            foreach (var item in oIteratorClass)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("sortowanie: alfabetycznie");
            foreach (var item in oIteratorClass.Sortuj1())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("sortowanie: alfabetycznie^(-1)");
            foreach (var item in oIteratorClass.Sortuj2())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("sortowanie: alfabetycznie jeśli zawiera podany ciąg znaków -> \"t\"");
            foreach (var item in oIteratorClass.Sortuj3())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");

            //Console.Write("Obiekt z GetEnumerator()  ->  ");
            //foreach (var item in oIteratorClass.Sortuj1())
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("");

            Console.WriteLine("\n--------------------------------\n");
            foreach (var item in tabStr.SortujCoXElem(3))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
#endregion
            
        }
    }
}
