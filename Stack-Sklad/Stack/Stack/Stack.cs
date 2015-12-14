using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack
    {

        //public object[] Object;
        //IList<object> Objects = new List<object>();
        private readonly IList<object> _objects = new List<object>();

        public void Push(object obj)
        {
            if (obj != null)
                _objects.Add(obj);
            else
                throw new InvalidOperationException();
        }

        public object Pop()
        {
            if (!_objects.Last().Equals(null))
                throw new InvalidOperationException();

            var last = _objects.Last();
            _objects.RemoveAt(_objects.Count - 1);
            return last;
        }

        public void Clear()
        {
            _objects.Clear();
            
            
        }
    }
}