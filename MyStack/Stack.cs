using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
	class Stack<T> : IStack<T>
	{
		private List<T> _stackList;

		public Stack()
		{
			_stackList = new List<T>();
		}

		public Stack(IEnumerable<T> collection)
		{
			_stackList = new List<T>(collection);
		}

		public int Count => _stackList.Count;

		public void Push(T item)
		{
			_stackList.Add(item);
		}

		public T Pop()
		{
			if (_stackList == null)
			{
				throw new InvalidOperationException("Queue is empty");
			}

			T lastItem = _stackList[Count - 1];
			_stackList.RemoveRange(Count - 1, 1);
			return lastItem;
		}

		public T Peek()
		{
			if (_stackList == null)
			{
				throw new InvalidOperationException("Queue is empty");
			}

			return _stackList[Count - 1];
		}

		public IEnumerator<T> GetEnumerator()
		{
			return _stackList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
