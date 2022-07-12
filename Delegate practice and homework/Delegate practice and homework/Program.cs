using System;
using System.Collections.Generic;

namespace Delegate_practice_and_homework
{
    class Program
    {

        public delegate void CheckString(string word);

        //public delegate bool CheckNums(int number);
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine(SumOdd(CheckOdd, arr));
            //Console.WriteLine(SumEven(CheckEven, arr));
            //Console.WriteLine(SumMoreThanFive(CheckMoreThanFive,arr));


            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = list.FindAll(m => m > 6);
            //var result1 = list.FindAll(CheckMoreThanFive);

            //var aaa = list.Find(m => m > 3);
            //Console.WriteLine(aaa);

            WordChanger(StringToUpper, "Akif");
            WordChanger(StringToLower, "SALAM");
        }

        public static void StringToUpper(string str)
        {
            Console.WriteLine(str.ToUpper()); 
        }

        public static void StringToLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        public static void WordChanger(CheckString func, string str)
        {
            func(str);
        }

        public static bool CheckMoreThanFive(int number)
        {
            return number > 5;
        }


        //public static bool CheckOdd(int number)
        //{
        //    return number % 2 != 0;
        //} 

        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }


        //public static int SumOdd(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach(var item in nums)
        //    {
        //        if (func (item))
        //        {
        //            sum += item;

        //        }
        //    }
        //    return sum;
        //}


        //public static int SumEven(Predicate<int>func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach(var item in nums)
        //    {
        //        if(func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //public static int SumMoreThanFive(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach(var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

    }
}
