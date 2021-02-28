using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("engin");

            Console.WriteLine(isimler.Lenght);
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Items);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

           
        }
    }
}
