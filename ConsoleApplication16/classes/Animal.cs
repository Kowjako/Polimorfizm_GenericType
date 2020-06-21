using ConsoleApplication16.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16.Classes
{
    abstract class Animal : ICloneable, AnimalComparable
    {
        protected string name;
        protected int age;
        protected string place;
        public static int counter = 0;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Place { get { return place; } set { place = value; } }
        public Animal() : this("Unknown", 0, "Unknown") { }
        public Animal(Animal a) : this(a.name, a.age, a.place) { }
        public Animal(string n, int a, string p)
        {
            counter++;
            name = n;
            age = a;
            place = p;
        }
        public override bool Equals(object obj)
        {
            var animal = (Animal)obj;
            if (obj != null)
            {
                if (name.CompareTo(animal.name) != 0) return false;
                if (age.CompareTo(animal.age) != 0) return false;
                if (place.CompareTo(animal.place) != 0) return false;
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            return $"Name = {name} Age = {age} Place = {place}";
        }
        public virtual int Compare(Animal x)
        {
            return this.age.CompareTo(x.age);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
