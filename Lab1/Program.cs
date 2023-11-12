using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LabOne
{
    internal class Program
    {

        public static void Main()
        {
            Console.Write("Введите математическое выражение: ");
            string mathExpression = Console.ReadLine().Replace(" ", "");

            List<int> numbers = new List<int>();
            List<char> operators = new List<char>();

            int i = 0;
            string number = "";

            while (i < mathExpression.Length)
            {
                if (char.IsDigit(mathExpression[i]))
                {
                    number += Convert.ToString(mathExpression[i]);

                    if (i == mathExpression.Length - 1)
                        numbers.Add(int.Parse(number));

                    i++;
                }

                else
                {
                    numbers.Add(int.Parse(number));
                    number = "";

                    operators.Add(mathExpression[i]);
                    i++;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(string.Join(" ", operators));
        }
    }
}