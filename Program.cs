using System;

namespace BasicThirteen
{
    class Program
    {

        //1.
        // public static void PrintNumbers()
        // {
        //     // Print all of the integers from 1 to 255.
        //     int i = 1;
        //     while (i <= 255){
        //         i = i + 1;
        //         Console.WriteLine(i);
        //     }
        // }

        //2.
        // public static void PrintOdds()
        // {
        //     // Print all of the odd integers from 1 to 255.
        //     int i = 1;
        //     while (i <= 255)
        //     {
        //         if(i % 2 != 0)
        //         {
        //             Console.WriteLine(i);
        //         }
        //         i = i + 1;
        //     }
        // }

        //2.A print odds giving arguement (for fun)
        // public static void PrintOdds(int i)
        // {
        //     // Print all of the odd integers from 1 to 255.
        //     while (i <= 255)
        //     {
        //         if(i % 2 != 0)
        //         {
        //             Console.WriteLine(i);
        //         }
        //         i = i + 1;
        //     }
        // }

        // public static void PrintSum()
        // {
        // // Print all of the numbers from 0 to 255, 
        // // but this time, also print the sum as you go. 

        //     for(int i = 0; i <= 255; i++){

        //         Console.WriteLine("new number: " + i + "  Sum: " + (i+=i));
        //     }
        // }

        // public static void LoopArray(int[] numbers)
        // {
        //     // Write a function that would iterate through each item of the given integer array and 
        //     // print each value to the console. 
        //     Console.WriteLine(numbers);
        //     foreach (int number in numbers)
        //     {
        //         Console.WriteLine(number);
        //     }

        // }

        // public static int FindMax(int[] numbers)
        // {
        // // Write a function that takes an integer array and prints and returns the maximum value in the array. 
        // // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
        // // or even a mix of positive numbers, negative numbers and zero.

        //     int maxNumber = numbers[0];
        //     for(int i = 0; i < numbers.Length ; i++)
        //     {
        //         if (numbers[i] > maxNumber)
        //         {
        //             maxNumber = numbers[i];
        //         }
        //     }
        //     Console.WriteLine(maxNumber);
        //     return maxNumber;
        // }

        // public static void GetAverage(int[] numbers)
        // {
        //     // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
        //     // For example, with an array [2, 10, 3], your program should write 5 to the console.
        //     int avgNumber = 0;
        //     int sum = 0;
        //     for(int i = 0; i < numbers.Length ; i++)
        //         {
        //             sum += numbers[i];
        //         }
        //         avgNumber = sum / numbers.Length;
        //     Console.WriteLine(avgNumber);
        // }

        // public static int[] OddArray()
        // {
        // // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
        // // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        // int[] odds = new int[255/2 + 1] ;
        // int num = 0;
        // for(int i=1; i <= 255 ; i++)
        //     {
        //         if(i % 2 != 0)
        //         {
        //             odds[num] = i;
        //             Console.WriteLine(odds[num]);
        //             num ++;
        //         }
        //     }
        //     return odds;
        // }

        // public static int GreaterThanY(int[] numbers, int y)
        // {
        //     // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
        //     // That are greater than the "y" value. 
        //     // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
        //     // (since there are two values in the array that are greater than 3).

        //     int nums = 0;
        //     for(int i = 0 ; i < numbers.Length ; i++)
        //     {
        //         if(numbers[i] > y)
        //         {
        //             nums ++;
        //         }
        //     }
        //     Console.WriteLine(nums);
        //     return nums;
        // }

        // public static void SquareArrayValues(int[] numbers)
        // {
        //     // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
        //     // For example, [1,5,10,-10] should become [1,25,100,100]
        //     for(int i = 0; i < numbers.Length ; i++)
        //     {
        //         numbers[i] = numbers[i] * numbers[i];
        //         Console.WriteLine(numbers[i]);
        //     }
        // }

        // public static void EliminateNegatives(int[] numbers)
        // {
        // // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
        // // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

        // for(int i = 0; i < numbers.Length ; i++)
        //     {
        //         if(numbers[i] < 0)
        //         {
        //             numbers[i] = 0;
        //         }
        //     Console.WriteLine(numbers[i]);
        //     }
        // }

        // public static void MinMaxAverage(int[] numbers)
        // {
        //     // Given an integer array, say [1, 5, 10, -2], create a function that prints t.he maximum number in the array, 
        //     // the minimum value in the array, and the average of the values in the array

        //     int max = numbers[0];
        //     int min = numbers[0];
        //     int avg = 0;
        //     int sum = 0;
        //     for(int i = 0; i < numbers.Length ; i++)
        //     {

        //         //max
        //         if(numbers[i] > max)
        //         {
        //             max = numbers[i];
        //         }
        //         else if(numbers[i] < min)
        //         {
        //             min = numbers[i];
        //         }
        //         sum += numbers[i];

        //     }
        //         avg = sum / numbers.Length;
        //         Console.WriteLine($"min = {min}");
        //         Console.WriteLine($"max = {max}");
        //         Console.WriteLine($"avg = {avg}");
        // }

        public static int[] ShiftValues(int[] numbers)
        {
        // Given an integer array, say [1, 5, 10, 7, -2], 
        // Write a function that shifts each number by one to the front and adds '0' to the end. 
        // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
        // it should become [5, 10, 7, -2, 0].

            for(int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
                numbers[numbers.Length - 1] = 0;
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }
            return numbers;

        }


        // public static object[] NumToString(int[] numbers)
        // {
        //     // Write a function that takes an integer array and returns an object array 
        //     // that replaces any negative number with the string 'Dojo'.
        //     // For example, if array "numbers" is initially [-1, -3, 2] 
        //     // your function should return an array with values ['Dojo', 'Dojo', 2].

        //     string dojo = "dojo";

        //     //have to convert whole array into object
        //     object[] array = new object[numbers.Length];
        //     for(int i = 0; i < numbers.Length ; i++)
        //     {
        //         if(numbers[i] < 0)
        //         {
        //             array[i] = dojo;
        //         }
        //         else
        //         {
        //             array[i] = numbers[i];
        //         }
        //         Console.WriteLine(array[i]);
        //     }
        //     return array;
        // }

        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();

            // int[] array = {1,2,5,3,6,4};
            // LoopArray(array);

            // int[] maxArray = {1,2,5,3,6,4}; 
            // FindMax(maxArray);

            // int[] avgArray = {2, 10, 3};
            // GetAverage(avgArray);

            // OddArray();

            // int[] greaterArray = {1,3,5,7}; 
            // GreaterThanY(greaterArray, 3);

            // int[] squareArray = {1,5,10,-10};
            // SquareArrayValues(squareArray);

            // int[] elimZero = {1,5,10,-2};
            // EliminateNegatives(elimZero);

            // int[] minMaxAvg = {1,5,10,-2};
            // MinMaxAverage(minMaxAvg);

            int[] shift = { 1, 5, 10, -2 };
            int[] shifted = ShiftValues(shift);

            // int[] numStr = { 1, -3, -2 };
            // NumToString(numStr);
        }
    }
}
