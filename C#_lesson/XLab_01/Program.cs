using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_XLab_01
{
    class Program
    {
        static void Main(string[] args)

        //создаю переменные
        short sh = 0; //-32678
        int i = 0; //16777215
        long lo = 0;
        float fl = 0;
        double d1 = 0;
        object obj1 = d1;
        double d2 = (double)obj1;
            //задаю для i,obj значение
            int i = 1;
        Console.WriteLine(i);
            //задаю для obj значение из i
            object obj = i; //боксинг
            Console.WriteLine(obj);
            //перевожу обджект в индекс и присваиваю в i
            int i = (int)obj; //анбоксинг
            Console.WriteLine(i)
    }
}
