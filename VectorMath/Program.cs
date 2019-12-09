using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);

            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");

            Console.WriteLine($"Object method Add: {one.Add(two)}");

            Console.WriteLine($"Operator Add: {one + two}");

            Console.WriteLine($"Operator Subtract: {one - two}");

            Console.WriteLine($"Operator Scaler: {2*one}");

            Console.WriteLine($"Operator Scaler: {two*2}");

            Console.WriteLine($"Operator should not be equal: {two == one}");

            Console.WriteLine($"Operator should be equal: {one == new Vector3(3,4,5)}");

            Console.WriteLine($"Operator should be incrmented: {one++}");

            Console.WriteLine($"Operator should be scaler: {~one}");
            if (one)
            {
                Console.WriteLine($"{one} is truthy");
            }
            else
            {
                Console.WriteLine($"{one} is falsy");
            }

            if (Vector3.Zero)
            {
                Console.WriteLine($"{Vector3.Zero} is truthy");
            }
            else
            {
                Console.WriteLine($"{Vector3.Zero} is falsy");
            }
        }
    }
}
