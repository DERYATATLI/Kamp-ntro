using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");

            list<string> Liste = new List<string>();
            Console.WriteLine(Liste.count);
        }
    }
}
