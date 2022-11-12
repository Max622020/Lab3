using System;

namespace Lab3
{
    class Program
    {
        static void Interval() // Second ex
        {
            Console.WriteLine("Enter x :");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int y = x * x;
            switch (y)
            {
                case (-1):
                    Console.WriteLine("Entered value in -1 Interval");
                    break;
                case (-4):
                    Console.WriteLine("Entered value in -4 Interval");
                    break;
                case (-3):
                    Console.WriteLine("Entered value in -3 Interval");
                    break;
                case (2):
                    Console.WriteLine("Entered value in -2 Interval");
                    break;
                case (3):
                    Console.WriteLine("Entered value in 3 Interval");
                    break;
                case (4):
                    Console.WriteLine("Entered value in 4 Interval");
                    break;
                default:
                    {
                        Console.WriteLine("Sorry this variant is invalid");
                        break;
                    }
            }


        }
        static int Min(int x, int y, int z)
        {
            int[] array = new int[3]; // 0-x 1-y 2-z
            array[0] = x;
            array[1] = y;
            array[2] = z;
            int temp = 0;
            Array.Sort(array);
            temp = array[0];
            return temp;
        }
        static int Function(int x, int y,int z) 
        {
            int temp = Min(x, y, z);
            int f = (Math.Max(x, y) + y);
            int j = (temp*temp) + x * y;
            return f / j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Лабораторна робота №3 на тему: <Керуючі оператори умовного та безумовного переходів>");
            Console.WriteLine("");
            Console.WriteLine("Варiант №3");
            Console.WriteLine("");
            Console.WriteLine("Виконав:Харченко Максим Олександрович");
            Console.WriteLine("");
            Console.WriteLine("Група: ЕС-137Бстн");
            Console.WriteLine("");
            Console.WriteLine("Enter values for x,y,z: ");
            int x, y, z;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine(Function(x, y, z));
            Interval();
        }
    }
}
