using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
         //mergesort subprogram
         //merge sorts are well suited for recursion
         //the dividing of the array that a merge sort does is part of the "divide and concur" process
         //very hard to understand and prgramming is very hard
            int[] Unsorted = {1,2,3,4,5,6,7,8};
            int[] Halfsize1 = new int[4];
            int[] Halfsize2 = new int[4];
            int[] Quartsize1 = new int[2];
            int[] Quartsize2 = new int[2];
            int[] Quartsize3 = new int[2];
            int[] Quartsize4 = new int[2];
            int Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8;
            Halfsize1[0] = Unsorted[0];
            Halfsize1[1] = Unsorted[1];
            Halfsize1[2] = Unsorted[2];
            Halfsize1[3] = Unsorted[3];
            Halfsize2[0] = Unsorted[4];
            Halfsize2[1] = Unsorted[5];
            Halfsize2[2] = Unsorted[6];
            Halfsize2[3] = Unsorted[7];
            Quartsize1[0] = Halfsize1[0];
            Quartsize1[1] = Halfsize1[1];
            Quartsize2[0] = Halfsize1[2];
            Quartsize2[1] = Halfsize1[3];
            Quartsize3[0] = Halfsize2[0];
            Quartsize3[1] = Halfsize2[1];
            Quartsize4[0] = Halfsize2[2];
            Quartsize4[1] = Halfsize2[3];
            Value1 = Quartsize1[0];
            Value2 = Quartsize1[1];
            Value3 = Quartsize2[0];
            Value4 = Quartsize2[1];
            Value5 = Quartsize3[0];
            Value6 = Quartsize3[1];
            Value7 = Quartsize4[0];
            Value8 = Quartsize4[1];
            Console.WriteLine(Value1);
            Console.WriteLine(Value2);
            Console.WriteLine(Value3);
            Console.WriteLine(Value4);
            Console.WriteLine(Value5);
            Console.WriteLine(Value6);
            Console.WriteLine(Value7);
            Console.WriteLine(Value8);
        


           
           
            
            

        }
    }
}
