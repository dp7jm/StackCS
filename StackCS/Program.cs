using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StackCS
{
    class Stack
    {
        private ArrayList _stack = new ArrayList();
        void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("null can't be assigned to stack");
            }
            this._stack.Add(obj);

        }
        object Pop()
        {
            object objectU = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return objectU;

        }
        void Clear()
        {
            _stack.Clear();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
