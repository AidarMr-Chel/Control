using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 4
            var x = new List<int>() { 1,2,3 };
            var y = new List<int>() { 4,5,6 };

            var z = Metod(x, y);
            foreach (var item in z)
                Console.WriteLine(item);
            ///
            Console.WriteLine("______________");
            /// 5
            Mapper<string, char> StringFirstElement = strLst => strLst[0];
            var z1 = new List<string>() { "aaa", "bb", "ccccccc" };
            var z2 = new List<char>();
            foreach (var i in z1)
                z2.Add(StringFirstElement(i));

            foreach (var i in z2)
                Console.WriteLine(i);
            ///
        }

        static List<T> Metod<T>(List<T> lst1, List<T> lst2) => lst1.Concat(lst2).ToList();

        delegate U Mapper<T, U>(T value);
    }
}
