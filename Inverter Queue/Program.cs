using System;
using System.Collections.Generic;

namespace Inverter_Queue
{
    class Program
    {
        static void Main(string[] args)

        {
            int cantidad = 0;
            do
            {
                Console.Write("Inserte la cantidad de elementos de la cola: ");
                cantidad = int.Parse(Console.ReadLine());
            } while (cantidad <= 0);
            Queue queue = new Queue();
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Elemento[{i + 1}]: ");
                int value = int.Parse(Console.ReadLine());
                queue.enconlar(value);
            }

            Console.Write("Elemento N: ");
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            int x = queue.cantidad();
            for (int i = 0; i < n; i++)
            {
                stack.Push(queue.tope().Value);
                queue.desencolar();
            }
            Queue queue1 = new Queue();
            for (int i = 0; i < x; i++)
            {
                if (i < n)
                    queue1.enconlar(stack.Pop());
                else
                {
                    queue1.enconlar(queue.tope().Value);
                    queue.desencolar();
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"{queue1.tope().Value}<-");
                queue1.desencolar();
            }
        }
    }
}
