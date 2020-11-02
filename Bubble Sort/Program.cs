using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static List<int> Num = new List<int>() { 8, 1, 7, 19, 9, 15, 19, 111 }; // Defining the list of numbers.

        static void Sorter()  // Creating a static sorting method, which sorts the list.
        {
            for (int e = 0; e < Num.Count - 1; e++)  // A "for" statement which will continue till last element is reached.
            {
                if (Num[e] < Num[e + 1] || Num[e] == Num[e + 1]) // "if" statement to check if the pair is already sorted and if so, it breaks and continues system with next pair.
                {
                    continue;
                }
                var BufOne = Num[e]; // 'BuffOne' and 'BuffTwo' are two buffer variables which stores value of both elements of pair for swapping purpose.
                var BufTwo = Num[e + 1];
                Num[e] = BufTwo; // Here Swapping is performed if needed. 
                Num[e + 1] = BufOne;
            }
        }

        static bool CheckIfDone()   // Here we create a method 'CheckIfDone',with a boolean type return, whose task is to check if the list is sorted.
        {
            
            bool t = true; // 't' is a boolean type variable with initial value 'True' and it will be used later.
            for (int i = 0;i < Num.Count - 1 && t == true; i++) // This loop helps in continuing the checking till last pair is checked.
            {
                if (Num[i] < Num[i + 1] || Num[i] == Num[i + 1]) // This statement check if the elements of pair are sorted or are equal and if so it declares 't' as true.
                {
                    t = true;
                }
                else // If the above statement is not satisfied this statement is initiated an 't' is declared 'false'. 
                {
                    t = false;
                }
                
            }
            return t; // This statement returns 't' as value of function. 
        }

        static void Main(string[] args)
        {

            
            while (CheckIfDone() == false) // This loop calls the 'Sorter' method till list is Sorted which is checked through 'CheckIfDone' method.
            {
                Sorter(); // Statement to call sorter function.
                
            }
            for (int z = 0; z < Num.Count; z++) // This is a Loop to print sorted list.
            {
                Console.WriteLine(Num[z]);
            }
                Console.ReadKey();
            
        }
    }
}
