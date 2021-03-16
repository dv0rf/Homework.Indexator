using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Indexator
{
    class Program
    {
        static void Main(string[] args)
        {
            myArray array = new myArray(10);
            array[2] = 15;
            Console.WriteLine(array[2]);
            
        }
    }
    /// <summary>
    /// 1.	Создать индексатор для одномерного массива который при установке значения 
    /// будет возводить в квадрат передаваемое значение переменной и устанавливать его
    /// для указанного индекса. При получении элемента массива по индексу будет
    /// возвращаться его текущее значение
    /// </summary>
    class myArray
    {
        int[] arr;
        Random rnd = new Random();

        public myArray(int size)
        {
            arr = new int[size];
        }
        
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            { 
                arr[index] = value * value;
            }
        }
    }
}
