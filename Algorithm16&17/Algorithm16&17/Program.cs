using System.Runtime.InteropServices;

namespace Algorithm16_17
{
    internal class Program
    {

        //Implementation of a Insertion sort


        static void insert(int[] arr) /* function to sort an aay with insertion sort */
        {
            int i, j, temp;
            int n = arr.Length;
            for (i = 1; i < n; i++)
            {
                temp = arr[i];
                j = i - 1;

                while (j >= 0 && temp <= arr[j])  /* Move the elements greater than temp to one position ahead from their current position*/
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = temp;
            }
        }

        static void printArr(int[] a) /* function to print the array */
        {
            int i;
            int n = a.Length;
            for (i = 0; i < n; i++)
                Console.Write(a[i] + " ");
        }
    
public static void Main(string[] args)
        {
            int[] a = { 78,12,100,34,23,9};
            Console.Write("Before sorting array elements are - \n");
            printArr(a);
            insert(a);
            Console.Write("\nAfter sorting array elements are - \n");
            printArr(a);
        }
    }
}

