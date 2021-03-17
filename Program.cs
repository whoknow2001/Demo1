using System;

namespace Exception
{
    class Program
    {

        static void Main(string[] args)
        {
            // int a,b;
            // do
            // {
            //     a = Convert.ToInt32(Console.ReadLine());
            //     b = Convert.ToInt32(Console.ReadLine());
            //     try
            //     {
            //         Console.WriteLine(a/b);
            //     }
            //     catch(DivideByZeroException dex)
            //     {
            //         Console.WriteLine("Divide By Zero Exception "+ dex.Message);
            //     }
            //     finally
            //     {
            //         Console.WriteLine("This is always called, whatever it has exception");
            //     }
            // }while(b==0);

            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0},{1}",a,b);
            swap<int>(ref a,ref b);
            Console.WriteLine("After swap: {0},{1}",a,b);

            string s1 = "Hello" ,s2 = "There";
            Console.WriteLine("Before swap: {0},{1}",s1,s2);
            swap<string>(ref s1,ref s2);
            Console.WriteLine("After swap: {0},{1}",s1,s2);
            Console.ReadLine();
        }
        static void swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
