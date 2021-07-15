using System;
using System.Collections.Generic;

namespace MyStack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> stack = new Stack<int>();

			for (int i = 1; i <= 3; i++)
			{
				stack.Push(i);
			}

			Console.WriteLine("After Push");
			foreach (var item in stack)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine($"Count: {stack.Count}");

			Console.WriteLine($"\nstack.Pop: {stack.Pop()}");

			Console.WriteLine("After Pop");
			foreach (var item in stack)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine($"Count: {stack.Count}");

			Console.WriteLine($"\nstack.Peek: {stack.Peek()}");

			Stack<int> stack2 = new Stack<int>(stack);

			Console.WriteLine("Stack2");
			foreach (var item in stack2)
			{
				Console.Write(item + " ");
			}
		}
	}
}
