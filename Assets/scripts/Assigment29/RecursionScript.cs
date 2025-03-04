using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class RecursionScript : MonoBehaviour
    {
        int FibonacciRecursive(int n) => n <= 1 ? n : FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);

        int FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
                (a, b) = (b, a + b);
            return b;
        }

        void Start()
        {
            Debug.Log($"Fibonacci Recursive (10): {FibonacciRecursive(10)}");
            Debug.Log($"Fibonacci Recursive (30): {FibonacciRecursive(30)}");
            Debug.Log($"Fibonacci Iterative (10): {FibonacciIterative(10)}");
            Debug.Log($"Fibonacci Iterative (30): {FibonacciIterative(30)}");
        }
    }
