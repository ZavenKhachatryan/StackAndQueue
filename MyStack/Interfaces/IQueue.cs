using System.Collections.Generic;

namespace MyStack
{
	public interface IQueue<T> : IEnumerable<T>
    {
        //
        // Summary:
        //     Gets the number of elements contained in the System.Collections.Generic.Stack`1.
        //
        // Returns:
        //     The number of elements contained in the System.Collections.Generic.Stack`1.
        public int Count { get; }
        //
        // Summary:
        //     Removes and returns the object at the beginning of the System.Collections.Generic.Queue`1.
        //
        // Returns:
        //     The object that is removed from the beginning of the System.Collections.Generic.Queue`1.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Collections.Generic.Queue`1 is empty.
        public T Dequeue();
        //
        // Summary:
        //     Adds an object to the end of the System.Collections.Generic.Queue`1.
        //
        // Parameters:
        //   item:
        //     The object to add to the System.Collections.Generic.Queue`1. The value can be
        //     null for reference types.
        public void Enqueue(T item);
        //
        // Summary:
        //     Returns the object at the beginning of the System.Collections.Generic.Queue`1
        //     without removing it.
        //
        // Returns:
        //     The object at the beginning of the System.Collections.Generic.Queue`1.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Collections.Generic.Queue`1 is empty.
        public T Peek();
        //
        // Summary:
        //     Removes all objects from the System.Collections.Generic.Queue`1.
        public void Clear();
    }
}
