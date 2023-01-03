using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssignment
{
    public partial class CustomList<type>
    {
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        private type[] _list;
        public type this [int position]
        {
            get{return _list[position];}
            set{_list[position]=value;}
        }
        public CustomList()
        {
            _count=0;
            _capacity=10;
            _list=new type[_capacity];
        }
        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _list=new type[_capacity];
        }
        public void Add(type data)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _list[_count]=data;
            _count++;
        
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            type[] temp=new type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_list[i];
            }
        }
        public void AddRange(CustomList<type> dataList)
        {
            _capacity=_count+dataList.Count+4;
            type[] temp=new type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_list[i];
            }
            int k=0;
            for(int j=0;j<dataList.Count+Capacity;j++)
            {
                temp[j]=dataList[k];
                k++;
            }
            _list=temp;
            _count++;
        }
        public void insert(int index,type item)
        {
            _capacity=Count+4;
            type[] temp=new type[_capacity];
            for(int i=0;i<_count;i++)
            {
                if(i<index)
                {
                    temp[i]=_list[i];
                }
                else if(i==index)
                {
                    temp[i]=item;
                    
                }
                else
                {
                  temp[i]=_list[i];  
                }
            }
            _list=temp;
            _count++;
        }
        public bool RemoveAt(int position)
        {
            if(position<_count)
            {
                for(int i=0;i<_count;i++)
                {
                    if(i>position)
                    {
                        _list[i-1]=_list[i];
                    }
                }
                _count++;
                return true;
            }
            return false;
        }
        public int IndexOf(type data)
        {
            int position=-1;
            for(int i=0;i<_count;i++)
            {
                if(data.Equals(_list[i]))
                {
                    position=i;
                    break;
                }
            }
            return position;
        }
        public bool Remove(type data)
        {
            int position=IndexOf(data);
            if(position>0)
            {
                return RemoveAt(position);
            }
            else
            {
                return false;
            }
        }
}
}