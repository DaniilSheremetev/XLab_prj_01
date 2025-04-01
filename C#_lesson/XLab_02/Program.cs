using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XLab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаю простые переменные
            short s = 0;
            int i = 0;
            long lo = 0;
            float fl = 0;
            double d = 0;

            //создаю объект
            object obj1 = d; //боксинг
            double d2 = (double)obj1; //анбоксинг

            i = (int)l; //создаю переменную
            l = i; //интовая переменная i назначается значением

            testFunc(ref i);
            var c = 0f;

            if (o!= null)
            {
                int i2 = (int)obj1;
            }
            int[array] myArray01 = new int[10000];
        }
        public void dmg()
        }
        int i = 0;
        object obj2 = i; //перемещение в кучу (боксинг)
        int j = (int)obj2; //перемещение из куи в стек (анбоксинг)
        {

        public void testFunc(in int 1) //"in" передает переменную, но не делает анбоксинг "сохраняет переменную"
        {
            i = 10;
            Debug.Log(i);
        }
       
    }
}
