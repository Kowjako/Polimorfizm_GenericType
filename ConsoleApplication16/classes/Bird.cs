using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16.Classes
{
    class Bird : Animal
    {
        protected string color;
        protected string food;
        public string Color { get { return color; } set { color = value; } }
        public string Food { get { return food; } set { food = value; } }
        public static Bird EnterBird(string s)
        {
            string[] info = s.Split(new char[] { ' ' });
            return new Bird { Name = info[0], Color = info[1], Food = info[2], Age = Convert.ToInt32(info[3]), Place = info[4] };
        }
        public Bird()
        {
            color = "unknown";
            food = "unknown";
        }
        public Bird(Bird b) : base(b)
        {
            color = b.color;
            food = b.food;
        }
        public Bird(string c, string f, string n, int a, string p) : base(n, a, p)
        {
            color = c;
            food = f;
        }
        public override bool Equals(object obj)
        {
            var bird = (Bird)obj;
            if (obj != null)
            {
                if (!base.Equals(bird)) return false;
                if (food.CompareTo(bird.food) != 0) return false;
                if (color.CompareTo(bird.color) != 0) return false;
                return true;
            }
            else return false;
        }
        public override int Compare(Animal x)
        {
            if (x.GetType().Name == this.GetType().Name)
            {
                Bird tmp = (Bird)x;
                return this.color.CompareTo(tmp.color);
            }
            return -1;
        }
        public override string ToString()
        {
            return $"Name = {name} Age = {age} Place = {place} Color = {color} Food = {food}";
        }
    }
}
