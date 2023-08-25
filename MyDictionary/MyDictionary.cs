using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<T,T1>
    {
        T[]  array;
        T[] temparray;

        T1[] array2;
        T1[] temparray2;


        public MyDictionary()
        {
            array = new T[0];
            array2 = new T1[0];
        }

        public void Add(T item,T1 item2)
        {
            temparray = array;
            temparray2 = array2;

            array = new T[temparray.Length+1];
            array2= new T1[temparray2.Length+1];
            for (int i = 0; i < temparray.Length; i++)
            {
                temparray[i] = array[i];
            }
            for (int i = 0; i < temparray2.Length; i++)
            {
                temparray2[i] = array2[i];
            }

            array[array.Length-1] = item;
            array2[array2.Length - 1] = item2;


            Console.WriteLine("{0}, {1}", item, item2);

        }


    }
}


