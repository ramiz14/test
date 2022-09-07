using System;
using System.Linq;
using System.Text;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task-2
            Console.WriteLine("Metni daxil edin");
            string input = Console.ReadLine();
            Console.WriteLine(ReverseArr(input));
            #endregion
        }

        #region Task-2
        static string ReverseArr(string input)
        {
            StringBuilder str = new StringBuilder();
            string[] arr = input.Split(" ");
            char[] chrArr = { };

            for (int i = 0; i < arr.Length; i++)
            {
                chrArr = arr[i].ToCharArray();
                Array.Reverse(chrArr);
                str.Append(chrArr);

                if (i != arr.Length - 1)
                {
                    str.Append(' ');
                }
            }
            return str.ToString();
        }
         #endregion
    }
}