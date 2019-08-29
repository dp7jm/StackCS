using System;
using System.Collections;

namespace StackCS
{
    class Stack
    {
        private ArrayList _stack = new ArrayList();
        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("null can't be assigned to stack");
            }
            this._stack.Add(obj);

        }
        public object Pop()
        {
            object objectU = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return objectU;

        }
        public void Clear()
        {
            _stack.Clear();

        }
    }
}
