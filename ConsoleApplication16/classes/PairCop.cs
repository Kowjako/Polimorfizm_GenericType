using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16.Classes
{
    class PairCop : Animal
    {
        protected string cop;
        protected int speed;
        public int Speed { get { return speed; } set { speed = value; } }
        public string Cop { get { return cop; } set { cop = value; } }
        public static PairCop EnterPaircop(string s)
        {
            string[] info = s.Split(new char[] { ' ' });
            return new PairCop { Name = info[0], Speed = Convert.ToInt32(info[1]), Cop = info[2], Age = Convert.ToInt32(info[3]), Place = info[4] };
        }
        public PairCop() : base()
        {
            cop = "unknown";
            speed = 0;
        }
        public PairCop(PairCop p) : base(p)
        {
            cop = p.cop;
            Speed = p.speed;
        }
        public PairCop(string c, int s, string n, int a, string p) : base(n, a, p)
        {
            cop = c;
            speed = s;
        }
        public override bool Equals(object obj)
        {
            var paircop = (PairCop)obj;
            if (obj != null)
            {
                if (!base.Equals(paircop)) return false;
                if (cop.CompareTo(paircop.cop) != 0) return false;
                if (speed.CompareTo(paircop.speed) != 0) return false;
                return true;
            }
            else return false;
        }
        public override int Compare(Animal x)
        {
            if (x.GetType().Name == this.GetType().Name)
            {
                PairCop tmp = (PairCop)x;
                return this.speed.CompareTo(tmp.speed);
            }
            return -1;
        }
        public override string ToString()
        {
            return $"Name = {name} Age = {age} Place = {place} Cops = {cop} Speed = {speed}";
        }
    }
}
