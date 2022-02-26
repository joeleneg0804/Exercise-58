using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_58
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the missing elements within a range in a given array of integers

            int[] arrNumbers = { 1, 3, 4, 6, 9 };
            int missingElement = 1, firstElement = 0, secondElement = 0;

            //Empty list to add missing elements
            List<int> missingElements = new List<int>();

            //Loop through array, find the missing elements between 2 adjacent elements
            for(int i = 0; i < arrNumbers.Length - 1; ++i)
            {
                firstElement = arrNumbers[i];
                secondElement = arrNumbers[i + 1];

                while(missingElement < secondElement)
                {
                    missingElement = missingElement + 1;

                    if(missingElement > firstElement && missingElement < secondElement)
                    {
                        missingElements.Add(missingElement);
                    }
                }
            }

            int iListSize = missingElements.Count;

            Console.WriteLine("There are " + iListSize + " elements missing. \n");

            for(int j = 0; j <= iListSize - 1; ++j)
            {
                Console.Write(missingElements[j] + " ");
            }

            Console.ReadLine();
        }
    }
}
