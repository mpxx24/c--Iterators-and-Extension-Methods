using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace iteratory
{
    class IteratorClass<T> : IEnumerable<T>
    {
        private readonly List<T> kontenerList = new List<T>();
        private readonly T parametr;

        public IteratorClass(T par, List<T> lista)
        {
            parametr = par;
            kontenerList = lista;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //sposób 1
            //foreach (var item in kontenerList)
            //{
            //    if (item.ToString().StartsWith(parametr.ToString()))
            //        yield return item;
            //}

            //sposób 2
            //
            var wynik = kontenerList.Where(x1 => x1.ToString().StartsWith(parametr.ToString()));
            //

            //sposób 3
            //var wynik = from x1 in kontenerList
            //            where x1.ToString().StartsWith(parametr.ToString())
            //            select x1;

            foreach (var variable in wynik)
            {
                yield return variable;
            }
            //throw new NotImplementedException();
            
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public IEnumerable Sortuj1()
        {
            var bufor = new List<T>();
            foreach (var item in kontenerList.SortujRosnaco())
            {
                bufor.Add(item);
            }
            foreach (var variable in bufor)
            {
                yield return variable;
            }
        }

        public IEnumerable Sortuj2()
        {
            var bufor = new List<T>();
            foreach (var item in kontenerList.SortujMalejaco())
            {
                bufor.Add(item);
            }
            foreach (var variable in bufor)
            {
                yield return variable;
            }
        }

        public IEnumerable Sortuj3()
        {

            var bufor = new List<T>();
            foreach (var item in kontenerList.SortujAlfJesliZawiera(parametr))
            {
                bufor.Add(item);
            }
            foreach (var variable in bufor)
            {
                yield return variable;
            }


        }
    }
}
