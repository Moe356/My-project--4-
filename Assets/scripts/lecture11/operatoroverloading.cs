using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11
{
    public class operatoroverloading
    {
        public int v;
        public operatoroverloading(int v)
        {
            this.v = v;
        }
        public static int operator + (operatoroverloading a,operatoroverloading b)
        {
            return a.v + b.v;
        }
        public static int operator + (operatoroverloading a, int b)
        {
            return a.v + b;
        }
        public static int operator + (int b, operatoroverloading a)
        {
            return a.v + b;
        }
    }
}