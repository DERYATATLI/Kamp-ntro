using System;
using System.Collections.Generic;

namespace OOp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager=new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYAp(krediler);

        }
    }
}
