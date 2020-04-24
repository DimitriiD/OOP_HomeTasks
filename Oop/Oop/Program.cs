using System;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars x = new Cars();
            x.марка = "Kia";
            x.модель = "Cee'd";
            x.количество_мест = 5;
            x.getМаркаМодель();
            Trucks y = new Trucks();
            y.специалная_надстройка("кунг","тонар");
            Console.WriteLine(y.srt);
            special_vehiclecs z = new special_vehiclecs();
            z.специалная_надстройка("кран", "урал кран");
            Console.WriteLine(z.srt);
        }
    }
}
