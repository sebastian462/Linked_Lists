using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DoubleList
{
    public class DoublyLinkedList<T>
    {
        private DoubleNode<T>? _head;
        private DoubleNode<T>? _tail;



        public DoublyLinkedList()
        {
            _head = null;
            _tail = null;
        }

        public void Insert(T data)
        {
            var newNode = new DoubleNode<T>(data);
            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
                return;
            }

            var current = _head;
            while (current != null && Comparer<T>.Default.Compare(current.Data, data) < 0)
            {
                current = current.Next;
            }
            if (current == null)
            {
                _tail!.Next = newNode;
                newNode.Prev = _tail;
                _tail = newNode;
            }

            else if(current.Prev == null)
            {               
                  newNode.Next = current;
                  current.Prev = newNode;
                  _head = newNode;
                
            }
            else
            {
                newNode.Next = current;
                newNode.Prev = current.Prev;
                current.Prev!.Next = newNode;
                current.Prev = newNode;
            }


        }

        public string GetForward()
        {
            var output = string.Empty;
            var current = _head;
            while (current != null)
            {
                output += $"{current.Data} -> ";
                current = current.Next;
            }
            output += "null";
            return output;
        }

        public string GetBackward()
        {
            {
                var output = string.Empty;
                var current = _tail;
                while (current != null)
                {
                    output += $"{current.Data} -> ";
                    current = current.Prev;
                }
                output += "null";
                return output;
            }
        }

        public void sortDescending()
        {
            var current = _head;
            DoubleNode<T>? temp = null;

            while (current != null)
            {
                temp = current.Prev;
                current.Prev = current.Next;
                current.Next = temp;
                current = current.Prev;
            }
            if (temp != null)
            {
                _head = temp.Prev;
            }

            var aux = _head;
            _head = _tail;
            _tail = aux;
        }

        public bool Contains(T data)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Data!.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;

        }

        public void Remove(T data)
        {
            var current = _head;
            while (current != null)
            {
                if (current.Data!.Equals(data))
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;

                    }
                    else
                    {
                        _head = current.Next;
                    }
                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        _tail = current.Prev;
                    }
                    return;
                }
                current = current.Next;
            }

        }

        public void Clear()
        {
            _head = null;
        }


        public List<T> Fads()

        {
            var modas = new List<T>();
            if(_head == null)
            {
                return modas;
            }


            var frecuency = new Dictionary<T, int>();
            var current = _head;
            while (current != null)
            {
              if (frecuency.ContainsKey(current.Data))
              {
                    frecuency[current.Data]++;
              }
              else
              {
                    frecuency[current.Data] = 1;
              }
                current = current.Next;
            }

            int maxfrecuency = frecuency.Values.Max();

            foreach (var par in frecuency)
            {
                if (par.Value == maxfrecuency)
                    modas.Add(par.Key);
            }
            return modas;

        }

        public void Graphic ()
        {
              if (_head == null)
              {
                Console.WriteLine("The list is void, need insert a new item.");
              }

            Dictionary<T, int> frecuency = new Dictionary<T, int>();
            var newNodo = _head;

            while (newNodo != null)
            {
                 if(frecuency.ContainsKey(newNodo.Data))
                 {
                    frecuency[newNodo.Data] ++;
                 }
                else
                {
                    frecuency[newNodo.Data] = 1; 
                }
                newNodo = newNodo.Next;
            }

            foreach (var par in frecuency)
            {
                Console.Write($"{par.Key} ");
                for (int i = 0; i < par.Value; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }


    }


}
