using System;
using System.Collections.Generic;

namespace stack
{
    public class Stack
    {
        private List<object> my_array = new List<object>();
        public object Pop()
        {
            if (this.my_array.Count > 0)
            {
                var lastIndex = my_array.Count - 1;
                var poppedObject = my_array[lastIndex];
                my_array.RemoveAt(lastIndex);
                return poppedObject;
            }
            else
                throw new InvalidOperationException("Stack is empty. You cannot pop.");
        }

        public void Push(object obj)
        {
            if (obj != null)
            {
                my_array.Add(obj);
            } else {
                throw new InvalidOperationException("You cannot add null objects to the stack");
            }
        }

        public void Clear()
        {
            my_array.Clear();
        }
    }

}