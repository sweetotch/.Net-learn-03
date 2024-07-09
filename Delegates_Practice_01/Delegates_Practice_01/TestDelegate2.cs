//2nd way to use delegates

namespace Delegates_Practice_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestDelegate2
    {
        delegate void Message(int i);

        public static void main()
        {
            void DisplayInter(int i) => Console.WriteLine($"Hello - Program2 class - {i}");

            Console.WriteLine("=============== 2nd example ===============");

            Message mess1;
            Message mess2;
            Message mess3;

            mess1 = DisplayInter;
            mess1 = Welcome.Display;
            mess3 = Buy.Display;

            mess1(1); // - anomaly like
            mess1(2);
            mess3(3);

        }

    }

    class Welcome
    {
        public static void Display(int i) => Console.WriteLine($"Hello - Welcome class - {i}");
    }

    class Buy
    {
        public static void Display(int i) => Console.WriteLine($"Hello - Buy class - {i}");
    }
}
