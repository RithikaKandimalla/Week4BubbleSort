﻿/* Anuthor :Rithika Kandimalla
  Date : 02/28/2044
 This is Bubble Sort Algorithm */

int[] bubble_sort_numbers = {  3, 62, 5, 16, 4, 10};
 
Console.WriteLine("Here is the original array that will be used to execute the Bubble Sort Algorithm: ");
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Here is the array after the execution of the Bubble Sort Algorithm: ");
Bubble_Sort(bubble_sort_numbers);
for (int i = 0; i < bubble_sort_numbers.Length; i++)
{
    Console.Write("  " + bubble_sort_numbers[i]);
}
Console.WriteLine("");
Console.WriteLine("Press any key to exit the program ...");
Console.ReadKey(true);
static void Bubble_Sort(int[] bs_arr)
{

    for (int i = 0; i < bs_arr.Length - 1; i++)
    {
        for (int x = 0; x < bs_arr.Length - i - 1; x++)
        {
            // In each nested for loop iteration check to see if the next element value is lower than the current element value
            // If the next element value is less, then conduct the swap
            if (bs_arr[x] > bs_arr[x + 1])
            {
                // Here we will swap temp and bs_arr[x]
                // The temp variable is used to temporarily hold the value of the current element so that it can be swapped
                int temp = bs_arr[x];
                bs_arr[x] = bs_arr[x + 1];
                bs_arr[x + 1] = temp;
            }  
        } 
    }  
}
