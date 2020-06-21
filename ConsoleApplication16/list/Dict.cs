using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication16.Classes;

namespace ConsoleApplication16.list
{
    class Dict<T,U>
    {
        private U[] keys = new U[0];
        private T[] elements = new T[0];
        static int i = 0;
        public void addElement(T element, U key)
        {
            if (keys.Contains(key) == true)
            {
                Console.WriteLine("Key is already used");
            }
            else
            {
                Array.Resize(ref keys, keys.Length + 1);
                Array.Resize(ref elements, elements.Length + 1);
                elements[i] = element;
                keys[i] = key;
                i++;
            }
        }
        public void getByKey(int key)
        {
            if (key < keys.Length)
                Console.WriteLine($"Element with key = {key} -> {elements[key]}");
            else Console.WriteLine("Index Out of Range :(");
        }
        public void CheckDictionary()
        {
            for (int i = 0; i < keys.Length; i++)
                Console.WriteLine($"Key = {keys[i]} Element = {elements[i]}");
        }
        public int Comparator(T c1, T c2)
        {
            if (c1 is Animal && c2 is Animal)
            {
                return (c1 as Animal).Compare(c2 as Animal);
            }
            else
            {
                Comparer<T> comparer = Comparer<T>.Default;
                if (comparer.Compare(c1, c2) >= 0) return 1;
            }
            return -1;
        }
        public void Sort()
        {
            for (int i = 1; i < elements.Length; i++)
            {
                T k = elements[i];
                int j = i;
                while (j > 0 && Comparator(elements[j - 1], k) > 0)
                {
                    Swap<T>(ref elements[j - 1], ref elements[j]);
                    Swap<U>(ref keys[j - 1], ref keys[j]);
                    j--;
                }
            }
        }
        public void Swap<X>(ref X a, ref X b)
        {
            X tmp = a;
            a = b;
            b = tmp;
        }
    }
}
