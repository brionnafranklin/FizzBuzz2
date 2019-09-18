using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class ArrayList
    {
        int[] thisArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        //public int Size = 15;
        public int nothing = -1;

        public int arraySize
        {
            set
            {

            }
            get
            {
                return thisArray.Length;
            }
        }
        /*public ArrayList ()
        {
            thisArray = new int[Size];
        }
        */
        public virtual void Add(int value)
        {
            int[] newArray = new int[arraySize + 1];
            newArray[arraySize] = value;
            

            //set empty values in new array to values in old array
            for (int i = 0; i < thisArray.Length; i++)
            {
                newArray[i] = thisArray[i];
            }
            //set old array to new array
            thisArray = newArray;

            arraySize++;

            return;
        }
        public virtual void Remove(int index)
        {

            int[] newArray = new int[thisArray.Length - 1];
            int newPosition = 0;


            //remove the number
            for (int i = 0; i < thisArray.Length; i++)
            {
                
                if (i != index)
                {
                    newArray[newPosition] = thisArray[i];
                    newPosition++;
                }
                
            }
            thisArray = newArray;

            /*
            for (int i = 0; i < arraySize; i++)
            {
                
                if (thisArray[i] % 3 == 0 && thisArray[i] % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (thisArray[i] % 3 == 0)
                {
                    Fizz();
                }

                else if (thisArray[i] % 5 == 0)
                {
                    Buzz();
                }
                else
                {
                    thisArray[i] = nothing;
                }
                return;
            }
            */
            
        }
        public virtual void Clear()
        {
           
            for (int i = 0; i < arraySize; i++)
            {
                thisArray[i] = nothing;
            }
        }
        public virtual int this[int index]
        {
            set
            {
                thisArray[index] = value; 
            }
            get
            {
                return thisArray[index];
            }
        }
        public int Length
        {
            get
            {
                return thisArray.Length;
            }
        }
    }
}
