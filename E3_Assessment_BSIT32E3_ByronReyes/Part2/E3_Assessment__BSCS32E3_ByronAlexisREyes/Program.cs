using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Assessment__BSCS32E3_ByronAlexisREyes {

class Program
{
    static void Main()
    {
        //1
        Console.Write("Enter the base of the triangle: ");
        double baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = 0.5 * baseLength * height;
        Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");

            //2
            int[] numbers = new int[5];

        Console.Write("Choose a formula (e.g., n^3, 2n-1, sqrt(n), 4n): ");
        string formula = Console.ReadLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            int n = i + 1;
            numbers[i] = EvaluateFormula(formula, n);
        }

        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();

        int largestElement = FindLargestElement(numbers);
        Console.WriteLine($"The largest element in the array is: {largestElement}");

        // 3
        for (int i = 1; i <= 10; i++)
        {
            double squareRoot = Math.Sqrt(i);
            Console.WriteLine($"Number: {i}, Square Root: {squareRoot}");
        }


        Console.ReadLine();
    }

    static int EvaluateFormula(string formula, int n)
    {
        int result = 0;

        string replacedFormula = formula.Replace("n", n.ToString());

        try
        {
            result = (int)new System.Data.DataTable().Compute(replacedFormula, "");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid formula");
        }

        return result;
    }

    static int FindLargestElement(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
}

