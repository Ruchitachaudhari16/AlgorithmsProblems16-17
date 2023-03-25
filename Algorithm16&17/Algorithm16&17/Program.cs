using System.Runtime.InteropServices;

namespace Algorithm16_17
{
    internal class Program
    {

        //Bubble sort program
        //Function to print Array
        public static void print(int[] arr)
        {
            //It will print array lenghth
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //Implementation of a bubble sort
        public static void bubble(int[] a)
        {
            //Length of array
            int n = a.Length;
            int i, j, temp;
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[j] < a[i])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

        }
           public static void Main(string[] args)
            {
                //Array Declaration 
             int[] a = { 15,100,25,8,38,17 };
                Console.WriteLine("Before sorting array elements are:");
            print(a);
                //Method to call sorted array

                bubble(a);
                Console.WriteLine("\n After sorting array elements are:-");
                print(a);

            }
        }
    }

