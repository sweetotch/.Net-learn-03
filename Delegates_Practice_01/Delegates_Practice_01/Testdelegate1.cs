//1st way to use delegates

namespace Delegates_Practice_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Testdelegate1
    {
        public static void main()
        {
            Console.WriteLine("=============== 1st example ===============");

            Message mess;

            mess = Hello;
            mess(0);

            mess = Buy;
            mess(123123);

            void Hello(int i)
            {
                i++;
                Console.WriteLine($"Hello, World!{i}");
            }

            void Buy(int i) => Console.WriteLine($"Buy, World!{i}");
        }

        delegate void Message(int i);

    }
}
