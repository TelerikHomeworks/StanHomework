using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBestElementInPortion
{
    class GetBestElementInPortion
    {
        static void SwapElements(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static int GetBestElement(int[] myArray, int position, bool desc)
        {
                int bestElem = position;

                for (int i = position + 1; i < myArray.Length; i++)
                {
                    if (desc ? myArray[i] < myArray[bestElem] : myArray[bestElem] < myArray[i])
                    {
                        bestElem = i;
                    }
                }

                return bestElem;
        }

        static void SelectionSort(int[] myArray, bool desc)
        {
            for (int i = 0; i < myArray.Length-1; i++)
            {
                    SwapElements(myArray, i, GetBestElement(myArray, i , desc));
            }
        }    

        static void Main(string[] args)
        {
            int[] someArray = { 1, 2, 3, 5, 4, 2, 3, 10, 5 };

            SelectionSort(someArray, false);

            //Print the array
            for (int i = 0; i < someArray.Length; i++)
            {
                Console.Write(someArray[i] + " ");
            }

        }
    }
}
