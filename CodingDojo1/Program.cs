using System;
using System.Collections.Generic;
using CodingDojo1.Stack;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            CodingDojo1.Stack.Stack<int> MyStack = new CodingDojo1.Stack.Stack<int>();
            MyStack.Push(2);
            MyStack.Push(3);
            MyStack.Peek();
            MyStack.Pop();
            MyStack.Peek();
            MyStack.Pop();
            MyStack.Pop();

            Console.ReadLine();

            CodingDojo1.Stack.Stack<TestClass> MyStackk = new CodingDojo1.Stack.Stack<TestClass>();
            MyStackk.Push(new TestClass(14));
            MyStackk.Push(new TestClass(18));
            MyStackk.Peek();

            Console.ReadLine();



        }
    }
}
