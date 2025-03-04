using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
                sum += num;
            return sum;
        }

        public static string RepeatString(this string str, int times)
        {
            return string.Concat(Enumerable.Repeat(str, times));
        }
    }