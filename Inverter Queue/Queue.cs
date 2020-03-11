using System;
using System.Collections.Generic;
using System.Text;

namespace Inverter_Queue
{
    class Queue
    {
        LinkedList<int> lista = new LinkedList<int>();
        LinkedListNode<int> current;

        public LinkedList<int> enconlar(int i)
        {
            if (lista.Count == 0)
            {
                lista.AddFirst(i);
                current = lista.Last;
            }
            else
            {
                lista.AddAfter(current, i);
                current = lista.Last;
            }
            return lista;
        }

        public LinkedList<int> desencolar()
        {
            lista.RemoveFirst();
            return lista;
        }

        public int cantidad()
        {
            return lista.Count;
        }

        public LinkedListNode<int> tope()
        {
            return lista.First;
        }
    }
}
