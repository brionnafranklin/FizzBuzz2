using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    public delegate void ChangeEventHandler(object sender, EventArgs e);
    public delegate void FizzBuzzEventHandler(object sender, EventArgs e);
    class ListWithChangedEvent : ArrayList
    {
        public ChangeEventHandler Changed;
        public FizzBuzzEventHandler fizz;
        public FizzBuzzEventHandler buzz;
        public FizzBuzzEventHandler fizzbuzz;

        protected virtual void OnFizz(EventArgs e)
        {
            fizz?.Invoke(this, e);
        }
        protected virtual void OnBuzz(EventArgs e)
        {
            buzz?.Invoke(this, e);
        }
        protected virtual void OnFizzbuzz(EventArgs e)
        {
            fizzbuzz?.Invoke(this, e);
        }
        public virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }
        public void FizzBuzz()
        {
            for (int i = 0; i < Length; i++)
            {

                if ((int)this[i] % 3 == 0 && (int)this[i] % 5 == 0)
                {
                    //if divisable by 3 and 5 call fizzbuzz
                    Console.Write(this[i]);
                    OnFizzbuzz(EventArgs.Empty);
                }
                else if ((int)this[i] % 3 == 0)
                {
                    //if divisable by 3 call fizz
                    Console.Write(this[i]);
                    OnFizz(EventArgs.Empty);
                }
                else if ((int)this[i] % 5 == 0)
                {
                    //if divisable by 5 call buzz
                    Console.Write(this[i]);
                    OnBuzz(EventArgs.Empty);
                }
                else
                {
                    //remove all other numbers
                    Remove(i);
                    i--;
                }
            }
        }
        public void Print()
        {
            //print all numbers in array
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(this[i]);
            }
        }
        public override void Add(int value)
        {
            base.Add(value);
            OnChanged(EventArgs.Empty);
        }
        public override void Remove(int index)
        {
            base.Remove(index);
            OnChanged(EventArgs.Empty);
        }
        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }
        public override int this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }

    }
}
