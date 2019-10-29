using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCode;

namespace GameCaro
{
    public class MyTack<T>
    {
        private static int MAX = 500;
        private T[] a = new T[MAX];
        private int top = -1;

        public int Count = 0;
        public void Push(T x)
        {
            if (!isFullStack())
            {
                this.a[top + 1] = x;
                this.top++;
                Count++;
            }
            return;
        }

        public T Pop()
        {
            T t = a[top];
            top--;
            Count--;
            return t;
        }
        public T Top()
        {
            return this.a[this.top];
        }

        public bool isEmpty()
        {
            if (top == -1)
                return true;
            return false;
        }

        public bool isFullStack()
        {
            if (top == MAX - 1)
                return true;
            return false;
        }

        public void Clear()
        {
            top = -1;
            Count = 0;
        }

        //internal void Push(PlayInfo playInfo)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
