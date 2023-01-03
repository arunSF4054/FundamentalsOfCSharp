using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace FinalAssignment
{
    public partial  class CustomList<type>:IEnumerable,IEnumerator
    {
        int i;
        public IEnumerator GetEnumerator()
        {
            i=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                ++i;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
               i=-1;
        }
        public object Current
        {
            get{return _list[i];}
        }
        
    }
}