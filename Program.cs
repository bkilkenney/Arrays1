using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] myArray = new int[5];  //new means data we are going to create
            myArray[0] = 12;           
            myArray[1] = 15;
            myArray[2] = 18;
            myArray[3] = 21;          //if you try to include more than 5 elements > throws exception
            myArray[4] = 24;
            //This is my Array and in the [0] index the value of 12 is assigned.  
            //Console.WriteLine(myArray[0]); 
            // [0] is the first element, [4] is the 5th 

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + ", "); 
            }
           


                
           
        




        }
    }
}
