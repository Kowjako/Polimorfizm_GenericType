using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication16.Classes;

namespace ConsoleApplication16.list
{
    class AnimalList
    {
        List<Animal> list = new List<Animal>();
        public void AddToEndAnimal(Animal x)
        {
            list.Add(x);
        }
        public void AddToPosAnimal(Animal x, int pos)
        {
            list.Insert(pos, x);
        }
        public void DeletePosAnimal(int pos)
        {
            list.RemoveAt(pos);
        }
        public void DeleteAllAnimal()
        {
            list.Clear();
        }
        public Animal GetByIndexAnimal(int pos)
        {
            return list[pos];
        }
        public void ChangeByIndexAnimal(int pos)
        {
            string s = Console.ReadLine();
            if (list[pos] is Bird) list[pos] = Bird.EnterBird(s);
            if (list[pos] is PairCop) list[pos] = PairCop.EnterPaircop(s);
            if (list[pos] is Mammals) list[pos] = Mammals.EnterMammal(s);
        }
        public void Sort()
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j].Compare(list[j + 1]) == 1)
                    {
                        Animal tmp = (Animal)list[j + 1].Clone();
                        Animal tmp2 = (Animal)list[j].Clone();
                        list[j + 1] = tmp2;
                        list[j] = tmp;
                    }
                }
            }
        }
        public void DisplayList()
        {
            foreach (Animal x in list)
            {
               Console.WriteLine(x.GetType().Name + ": "+x.ToString());
            }
        }
    }
}

