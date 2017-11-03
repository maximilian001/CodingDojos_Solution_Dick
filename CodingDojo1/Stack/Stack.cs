using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class Stack<T>
    {
        private StackElem<T> current; //Unser Stack

        public void Push(T elem) //element hinzufügen
        {
            if (current == null) // noch kein Elment vorhanden -> 1ste hinzufügen
            {
                current = new StackElem<T>();
                current.Value = elem;
                current.Next = null;

            }
            else
            {
                StackElem<T> temp = new StackElem<T>();
                temp.Value = elem;
                temp.Next = current;

                current = temp;
            }
        }

        public void Pop()
        {
            if(current != null)
            {
                Console.WriteLine("Element mit Wert: "+current.Value+" wurde gelöscht!");
                current = current.Next;
            }
            else
            {
                Console.WriteLine("Stack ist leer!! Bitte zuerst ein Element hinzufügen!");
            }
        }

        public void Peek()
        {
            Console.WriteLine("Das aktuelle Element hat den Wert: "+current.Value);
        }

    }
}
