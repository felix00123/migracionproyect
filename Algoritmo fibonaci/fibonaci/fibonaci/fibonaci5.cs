using System;

namespace fibonaci
{
    public static class fibonaci5
    {
        public static void  print5fibonaci(int num) {

            int num2 = num - 1;
            int result = 0;

            for (int i = 0; i < 5; i++)
            {
                result = num + num2;
                Console.WriteLine(result );
                  num2=num;
                  num = result;
                 result = 0;
                
            }

            Console.ReadKey();
        }

    }
}
