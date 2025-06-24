// See https://aka.ms/new-console-template for more information
using GitLearningDemo;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, This is branch 1 :)");
//Console.WriteLine("Hello, This new changes in branch 1 :)");
//Console.WriteLine("Hello, This another new changes in branch 1 :)");
//Console.WriteLine("Hello, This is branch 2 :)");
//Console.WriteLine("Hello, This new changes in branch 2 :)");


public partial class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, This is branch 1 :)");
        Console.WriteLine("Hello, This new changes in branch 1 :)");
        Console.WriteLine("Hello, This another new changes in branch 1 :)");
        Console.WriteLine("Hello, This is branch 2 :)");
        Console.WriteLine("Hello, This new changes in branch 2 :)");

        Logic logic = new Logic();


        //logic.SumOfNumbersInString("a11b2c3");

        //Console.WriteLine("Enter the number:");
        //int num = Convert.ToInt32(Console.ReadLine());

        //logic.Pattern(num);

        //logic.FizzBuzz();

        //logic.PrimeNumber(9);

        //Console.WriteLine("Enter the string:");
        string str1 = Console.ReadLine();
        //string str2 = Console.ReadLine();

        //logic.Anagram(str1, str2);

        logic.ReverseWord(str1);

        //logic.RomanToInteger(str1);

        //Console.WriteLine("Enter the string:");
        //string[] arr = ["flower", "flow", "flight"];

        //logic.LongestCommonPrefix(arr);

        //Console.WriteLine("Enter the first arrry dimention:");
        //int arr1row = Convert.ToInt32(Console.ReadLine());
        //int arr1col = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter the second arrry dimention:");
        //int arr2row = Convert.ToInt32(Console.ReadLine());
        //int arr2col = Convert.ToInt32(Console.ReadLine());


        //logic.MultiArrry(arr1row, arr1col, arr2row, arr2col);

        Console.ReadKey();
    }
}








