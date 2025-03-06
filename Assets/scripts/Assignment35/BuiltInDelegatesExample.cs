using UnityEngine;
using System;

namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {
            Action logMessage = SimpleLog;
            logMessage();

            Func<int, int> square = Square;
            Debug.Log("Square: " + square(5));
            Predicate<int> isEven = IsEven;
            Debug.Log("Is 4 even? " + isEven(4));
        }

        void SimpleLog()
        {
            Debug.Log("Hello from Action delegate!");
        }

        int Square(int x)
        {
            return x * x;
        }

        bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
