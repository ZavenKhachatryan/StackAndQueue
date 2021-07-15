using System;
using System.Collections.Generic;

namespace MyStack
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<int> queue = new Queue<int>();

			for (int i = 0; i < 5; i++)
			{
				queue.Enqueue(i);
			}

			Console.WriteLine("After Enqueue: ↓");
			foreach (var item in queue)
			{
				Console.Write($"{item} ");
			}

			Console.WriteLine($"\nCount: {queue.Count}");
			Console.WriteLine($"queue.Dequeue: {queue.Dequeue()}");

			Console.WriteLine("After Dequeue: ↓");
			foreach (var item in queue)
			{
				Console.Write($"{item} ");
			}

			Console.WriteLine($"\nCount: {queue.Count}");
			Console.WriteLine($"queue.Peek: {queue.Peek()}");

			Console.WriteLine("After Peek: ↓");
			foreach (var item in queue)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine($"\nCount: {queue.Count}");

			queue.Clear();

			Console.WriteLine("After Clear: ↓");
			foreach (var item in queue)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine($"\nCount: {queue.Count}");

			//#region Stack
			//Stack<int> stack = new Stack<int>();

			//for (int i = 1; i <= 3; i++)
			//{
			//	stack.Push(i);
			//}

			//Console.WriteLine("After Push");
			//foreach (var item in stack)
			//{
			//	Console.Write(item + " ");
			//}
			//Console.WriteLine($"Count: {stack.Count}");

			//Console.WriteLine($"\nstack.Pop: {stack.Pop()}");

			//Console.WriteLine("After Pop");
			//foreach (var item in stack)
			//{
			//	Console.Write(item + " ");
			//}
			//Console.WriteLine($"Count: {stack.Count}");

			//Console.WriteLine($"\nstack.Peek: {stack.Peek()}");

			//Stack<int> stack2 = new Stack<int>(stack);

			//Console.WriteLine("Stack2");
			//foreach (var item in stack2)
			//{
			//	Console.Write(item + " ");
			//}
			//#endregion Stack

		}
	}
}
