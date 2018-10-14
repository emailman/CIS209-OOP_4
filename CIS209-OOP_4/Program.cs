using System;

namespace CIS209_OOP_4
{
    static class Program
    {
        static void Main()
        {
            Object[] objects = {
                                    new Tiger(),
                                    new Chicken(),
                                    new Orange(),
                                    new Apple()
                                };

            foreach (var thing in objects)
            {
                if (thing is Animal)
                    Console.WriteLine(((Animal)thing).Sound());

                if (thing is IEdible) 
                    Console.WriteLine(((IEdible)thing).HowToEat());
            }
        }
    }
}
