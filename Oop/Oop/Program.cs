using System;
using NLog;
using System.Collections.Generic;
using System.Linq;
namespace Oop
{
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            log.Info("старт");
            Cars x = new Cars();
            x.марка = "Kia";
            x.модель = "Cee'd";
            x.количество_мест = 5;
            x.getМаркаМодель();
            Trucks y = new Trucks();
            y.специалная_надстройка("кунг","тонар");
            Console.WriteLine(y.srt);
            y.марка = "Kamaz";
            y.модель = "5490";
            y.количество_мест = 2;
            special_vehiclecs z = new special_vehiclecs();
            z.марка = "Ural";
            z.модель = "4320";
            z.количество_мест = 2;
            z.специалная_надстройка("кран", "урал кран");
            Console.WriteLine(z.srt);
            try
            {
                Console.WriteLine("Введите количество мест {0}", z.srt);
                z.количество_мест = int.Parse(Console.ReadLine());

            }
            catch(FormatException )
            {
                Console.WriteLine("ошибка ввода");
                log.Debug("ошибка ввода количества мест {0}",z.srt);

            }
            List<Vehicles> Lst = new List<Vehicles>();
            Lst.Add(x);
            Lst.Add(y);
            Lst.Add(z);
            var Lst1 = Lst.OrderBy(l => l.марка);
            Console.WriteLine();
            foreach (Vehicles c in Lst)
            {
                Console.WriteLine(c.марка);
            }
            Console.WriteLine();
            foreach (Vehicles c1 in Lst1)
            {
                Console.WriteLine(c1.марка);
            }
        }
    }
}
