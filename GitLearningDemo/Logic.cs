using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLearningDemo
{
    public class Logic
    {

       

        //Sum of numbers in string
        public void SumOfNumbersInString(string str)
        {

            int temp = 0;
            string res = "";
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    res += str[i];
                }
                else
                {
                    if (int.TryParse(res.ToString(), out temp))
                    {
                        sum += temp;
                    }
                    res = "";
                }
            }
            if (!string.IsNullOrEmpty(res))
            {
                sum += int.Parse(res);
            }
            Console.WriteLine(sum);
        }

        //pattern
        public void Pattern(int num)
        {
            int num1 = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num1 + " ");
                    num1++;
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (i % 2 == 0)
                        Console.Write((i * i * i) + " ");
                    else
                        Console.Write(i + " ");

                }
                Console.WriteLine();
            }

            char ch = 'A';
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(ch + " ");
                    ch++;
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (i == j || j == (num - i + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");

            }

            for (int i = num; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
                for (int k = 0; k <= num - i; k++)
                {
                    Console.Write(" ");
                }

            }
        }

        //Palindrome string
        public void Palindrome(string str)
        {
            string revStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }
            if (str.Equals(revStr))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }

        //Palindrome number
        public void PalindromeNumber(int num)
        {
            int revNum = 0;
            int temp = num;
            while (num > 0)
            {
                int digit = num % 10;
                revNum = (revNum * 10) + digit;
                num /= 10;
            }
            if (temp == revNum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        //Prime number
        public void PrimeNumber(int num)
        {
            bool isPrime = true;
            if (num < 2)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }

        //3 and 5 multiplie prints
        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

                //string result = string.Empty;
                //if (i % 3 == 0)
                //{
                //    result += "Fizz";
                //}
                //if (i % 5 == 0)
                //{
                //    result += "Buzz";
                //}
                //if (!string.IsNullOrEmpty(result))
                //{
                //    result = Convert.ToString(i);
                //}
                //Console.WriteLine(result);
            }


        }

        //Anagram
        public void Anagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not Anagram");
                return;
            }
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            string sortedStr1 = new string(arr1);
            string sortedStr2 = new string(arr2);
            if (sortedStr1.Equals(sortedStr2))
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }

        //ReverseString 
        public void ReverseWord(string revStr)
        {
            //var arr = revStr.Split(' ').Reverse();
            //Console.WriteLine(string.Join(" ", arr));

            string str = "";

            List<string> list = new List<string>();
            for (int i = 0; i < revStr.Length; i++)
            {
                if (revStr[i] == ' ')
                {
                    list.Add(str);
                    str = "";
                }
                else if ((i + 1) == revStr.Length && revStr[i] != ' ')
                {
                    str += revStr[i];
                    list.Add(str);
                    str = "";
                }
                else
                {
                    str += revStr[i];
                }
            }
            for (int j = list.Count-1; j >= 0; j--)
            {
                Console.Write(" "+list[j]);
            }
        }


        //public void ReverseWord(string str) {


        //    int count = 0;
        //    int j = 0;
        //    string word = "";
        //    if(str.Length > 0)
        //    {
        //        count++;

        //        for (int i = 0; i < str.Length; i++)
        //        {
        //            if (str[i] == ' ')
        //            {
        //                count++;

        //            }
        //        }

        //        string[] reverse = new string[count];
        //        int k = 0;
        //        for (int i = 0; i < str.Length; i++)
        //        {
        //            if (str[i] != ' ')
        //            {
        //                word += str[i];

        //            }
        //            else
        //            {
        //                reverse[k] = word;
        //                k++;

        //                word = "";
        //            }
        //        }

        //        for (int l = reverse.Length; l >=0 ; l--)
        //        {
        //            Console.Write(reverse[l] + " ");
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine("");
        //    }

        //}



        //input: "This is test"
        //output: "tset si sihT"

        public string ReverseString(string input)
        {
            string result = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            return result;
        }


        //RomanToInteger
        public void RomanToInteger(string s)
        {
            int sum = 0;
            int range = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    if ((i + 1) <= range)
                    {
                        if (s[i + 1] == 'V')
                        {
                            sum += 4;
                            i += 1;
                        }
                        else if (s[i + 1] == 'X')
                        {
                            sum += 9;
                            i += 1;
                        }
                        else
                        {
                            sum += 1;
                        }
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                else if (s[i] == 'V')
                {
                    sum += 5;
                }
                else if (s[i] == 'X')
                {
                    if ((i + 1) <= range)
                    {
                        if (s[i + 1] == 'L')
                        {
                            sum += 40;
                            i += 1;
                        }
                        else if (s[i + 1] == 'C')
                        {
                            sum += 90;
                            i += 1;
                        }
                        else
                        {
                            sum += 10;
                        }
                    }
                    else
                    {
                        sum += 10;
                    }
                }
                else if (s[i] == 'L')
                {
                    sum += 50;
                }
                else if (s[i] == 'C')
                {
                    if ((i + 1) <= range)
                    {
                        if (s[i + 1] == 'D')
                        {
                            sum += 400;
                            i += 1;
                        }
                        else if (s[i + 1] == 'M')
                        {
                            sum += 900;
                            i += 1;
                        }
                        else
                        {
                            sum += 100;
                        }
                    }
                    else
                    {
                        sum += 100;
                    }
                }
                else if (s[i] == 'D')
                {
                    sum += 500;
                }
                else if (s[i] == 'M')
                {
                    sum += 1000;
                }
            }
            Console.WriteLine(sum);
        }

        //LongestCommonPrefix
        public void LongestCommonPrefix(string[] arr)
        {
            string strs = arr.OrderBy(x => x.Length).FirstOrDefault() ?? "";
            string res = "";
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i].Length < strs.Length)
            //    {
            //        strs = arr[i];

            //    }
            //}


            for (int i = 0; i < strs.Length; i++)
            {
                bool isTrue = true;
                for (int j = 0; j < arr.Length; j++)
                {

                    if (strs[i] != arr[j][i])
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                    res += strs[i];
                else
                    break;
            }
            Console.WriteLine(res);
        }

        //Multi-dimention array multiplication
        public void MultiArrry(int arr1row, int arr1col, int arr2row, int arr2col)
        {

            if (arr1col != arr2row)
            {
                Console.WriteLine("Please enter the valid number");
            }
            else
            {
                int[,] a = new int[arr1row, arr1col];
                int[,] b = new int[arr2row, arr2col];
                int[,] ans = new int[arr1row, arr2col];

                for (int i = 0; i < arr1row; i++)
                {
                    for (int j = 0; j < arr1col; j++)
                    {
                        Console.WriteLine("a[" + i + "," + j + "] = ");
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < arr2row; i++)
                {
                    for (int j = 0; j < arr2col; j++)
                    {
                        Console.WriteLine("b[" + i + "," + j + "] = ");
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < arr1row; i++)
                {
                    for (int j = 0; j < arr1col; j++)
                    {
                        ans[i, j] = 0;
                        for (int k = 0; k < arr1col; k++)
                        {
                            ans[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                for (int i = 0; i < arr1row; i++)
                {
                    for (int j = 0; j < arr1col; j++)
                    {
                        Console.Write(ans[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
