using System.Collections.Generic;
using System.IO;

namespace HelloWorld.Intermediate.Exercises
{
    class Stack
    {
        private readonly List<object> _stack = new List<object>();
        public void Push(object obj)
        {
            if (obj is null)
                throw new IOException("The object cannot be null");

            _stack.Add(obj);
        }

        public object Pop()
        {
            var numberOfItems = _stack.Count;
            if (numberOfItems == 0)
                throw new IOException("Cannot perform this method on an empty stack!");

            var output = _stack[numberOfItems - 1];
            _stack.RemoveAt(numberOfItems - 1);
            return output;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}