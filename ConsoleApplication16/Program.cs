using ConsoleApplication16.Classes;
using ConsoleApplication16.list;
using System;
namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Primitive types
            Dict<string,string> myarr = new Dict<string,string>();
            myarr.addElement("sinie","first");
            myarr.addElement("zakaty","second");
            myarr.addElement("kak","third");
            myarr.addElement("chernaya","fourth");
            myarr.addElement("rosa","fifth");
            myarr.CheckDictionary();
            myarr.getByKey(3);
            Console.WriteLine("=====SORTING======");
            myarr.Sort();
            myarr.CheckDictionary();
            #endregion
            #region Classes
            Bird b = new Bird("red", "woda", "Gragas", 15, "Wroclaw");
            Bird b1 = new Bird("blue", "mushrooms", "Jax", 17, "Gdynia");
            Mammals m = new Mammals("170", "80", "Katarina", 18, "Warszawa");
            Mammals m1 = new Mammals("150", "80", "Warwick", 45, "Warszawa");
            PairCop p = new PairCop("2", 290, "Lux", 19, "Gdansk");
            PairCop p1 = new PairCop("2", 280, "Veigar", 51, "Gdansk");
            PairCop p2 = new PairCop("2", 270, "Nokturn", 11, "Gdansk");
            PairCop p3 = new PairCop("2", 260, "talon", 33, "Gdansk");
            Dict<Animal,int> animalarr = new Dict<Animal,int>();
            animalarr.addElement(b,1);
            animalarr.addElement(b1,2);
            animalarr.addElement(m,3);
            animalarr.addElement(m1,4);
            animalarr.addElement(p,5);
            animalarr.addElement(p1,6);
            animalarr.addElement(p2,7);
            animalarr.addElement(p3,8);
            animalarr.CheckDictionary();
            Console.WriteLine("=====SORTING======");
            animalarr.Sort();
            animalarr.CheckDictionary();
            #endregion
            Console.Read();  
            Console.ReadKey();

        }
    }
}
