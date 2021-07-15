using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
	class Queue<T> : IQueue<T>
	{
		private List<T> _queueList;
		public Queue()
		{
			_queueList = new List<T>();
		}

		public Queue(IEnumerable<T> collection)
		{
			_queueList = new List<T>(collection);
		}

		public int Count => _queueList.Count;

		public void Enqueue(T item)
		{
			_queueList.Add(item);
		}
		public T Dequeue()
		{
			if (_queueList == null)
			{
				throw new InvalidOperationException("Queue is empty");
			}

			T firstItem = _queueList[0];
			_queueList.RemoveRange(0, 1);
			return firstItem;
		}
		public T Peek()
		{
			if (_queueList == null)
			{
				throw new InvalidOperationException("Queue is empty");
			}

			return _queueList[0];
		}

		public void Clear()
		{
			_queueList.Clear();
		}

		public IEnumerator<T> GetEnumerator()
		{
			return _queueList.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
