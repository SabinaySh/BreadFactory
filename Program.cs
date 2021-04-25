using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            BreadFactory Bread = new BreadFactory();

            Bread.Cook();
            Bread.Cook(BreadType.Double);
            Bread.Cook(3);
            //breadFactory.Cook(BreadType.Double, 5);

            Console.WriteLine(Bread.SingleBreadCount);
            Console.WriteLine(Bread.DoubleBreadCount);
            Console.WriteLine(Bread.Income);
        }
    }
}
