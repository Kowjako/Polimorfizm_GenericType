using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16.Classes
{
    class Mammals : Animal
    {
        protected string height;
        protected string weight;
        public string Height { get { return height; } set { height = value; } }
        public string Weight { get { return weight; } set { weight = value; } }
        public static Mammals EnterMammal(string s)
        {
            string[] info = s.Split(new char[]{' '});
            return new Mammals { Name = info[0], Height = info[1], Weight = info[2], Age = Convert.ToInt32(info[3]), Place = info[4] };
        }
        public Mammals() : base()
        {
            height = "unknown";
            weight = "unknown";
        }
        public Mammals(Mammals m) : base(m)
        {
            height = m.height;
            weight = m.weight;
        }
        public Mammals(string h, string w, string n, int a, string p) : base(n, a, p)
        {
            height = h;
            weight = w;
        }
        public override bool Equals(object obj)
        {
            var smalleat = (Mammals)obj;
            if (obj != null)
            {
                if (!base.Equals(smalleat)) return false;
                if (height.CompareTo(smalleat.height) != 0) return false;
                if (weight.CompareTo(smalleat.weight) != 0) return false;
                return true;
            }
            else return false;
        }
        public override int Compare(Animal x)
        {
            if (x.GetType().Name == this.GetType().Name)
            {
                Mammals tmp = (Mammals)x;
                return this.height.CompareTo(tmp.height);
            }
            return -1;
        }
        public override string ToString()
        {
            return $"Name = {name} Age = {age} Place = {place} Weight = {weight} Height = {height}";
        }
    }
}
