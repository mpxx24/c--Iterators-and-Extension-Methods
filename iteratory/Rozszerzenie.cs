using System;
using System.Collections.Generic;
using System.Linq;

namespace iteratory
{
    static class Rozszerzenie 
    {
        public static IEnumerable<T> SortujMalejaco<T>(this IEnumerable<T> kontener)
        {
            var dzialanie = from x1 in kontener
                            orderby x1 descending
                            select x1;

            return dzialanie.ToList();
        }

        public static IEnumerable<T> SortujRosnaco<T>(this IEnumerable<T> kontener)
        {
            var dzialanie = from x1 in kontener
                            orderby x1 ascending
                            select x1;

            return dzialanie.ToList();
        }

        public static IEnumerable<T> SortujCoXElem<T>(this IEnumerable<T> kontener, int parametr)
        {
            var wynik = new List<T>();
            var i = 0;

            foreach (var item in kontener)
            {
                if (i % parametr == 0)
                {
                    wynik.Add(item);
                }                
                i++;
                
            }
            //var dzialanie = kontener.Where(x1 => x1.ToString().Count() ... parametr == 0);
            return wynik;
        }

        public static IEnumerable<T> SortujMalejacoJesliZaczynaSieOd<T>(this IEnumerable<T> kontener, T parametr)
        {
            //var dzialanie = from x1 in kontener
            //                where x1.ToString().StartsWith(parametr.ToString())
            //                orderby x1 descending
            //                select x1;
            var dzialanie = kontener.Where(x1 => x1.ToString().StartsWith(parametr.ToString())).SortujMalejaco();

            return dzialanie;
        }

        public static IEnumerable<T> SortujRosnacoJesliZaczynaSieOd<T>(this IEnumerable<T> kontener, T parametr)
        {
            //var dzialanie = from x1 in kontener
            //                where x1.ToString().StartsWith(parametr.ToString())
            //                orderby x1 ascending
            //                select x1;
            var dzialanie = kontener.Where(x1 => x1.ToString().StartsWith(parametr.ToString())).SortujRosnaco();

            return dzialanie;
        }

        public static IEnumerable<T> SortujAlfJesliZawiera<T>(this IEnumerable<T> kontener, T parametr)
        {

            //var dzialanie = from x1 in kontener
            //                where x1.ToString().Contains(parametr.ToString())
            //                orderby x1 ascending
            //                select x1;
            var dzialanie = kontener.Where(x1 => x1.ToString().Contains(parametr.ToString())).SortujRosnaco();

            return dzialanie;
        }

        //public static IEnumerable<T> SortujPoWlasciwosciach<T>(this IEnumerable<T> kontener, T parametr)
        //{
        //    var test = new List<T>();

        //    test = 
        //}
    }
}
