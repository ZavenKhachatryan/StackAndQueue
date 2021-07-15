using System.Collections.Generic;

namespace MyStack
{
    public interface IStack<T> : IEnumerable<T>
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
        //     Returns the object at the top of the System.Collections.Generic.Stack`1 without
        //     removing it.
        //
        // Returns:
        //     The object at the top of the System.Collections.Generic.Stack`1.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Collections.Generic.Stack`1 is empty.
        public T Peek();
        //
        // Summary:
        //     Removes and returns the object at the top of the System.Collections.Generic.Stack`1.
        //
        // Returns:
        //     The object removed from the top of the System.Collections.Generic.Stack`1.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Collections.Generic.Stack`1 is empty.
        public T Pop();
        //
        // Summary:
        //     Inserts an object at the top of the System.Collections.Generic.Stack`1.
        //
        // Parameters:
        //   item:
        //     The object to push onto the System.Collections.Generic.Stack`1. The value can
        //     be null for reference types.
        public void Push(T item);
    }
}