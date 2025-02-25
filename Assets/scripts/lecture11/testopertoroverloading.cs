using System.Collections;
using System.Collections.Generic;
using Lecture11;
using UnityEngine;

namespace Lecture11
{
    public class testopertoroverloading : MonoBehaviour
    {
        void start()
        {
            operatoroverloading a = new operatoroverloading(5);
            operatoroverloading b = new operatoroverloading(10);
            Debug.Log(a + b);
            Debug.Log(a + 2);
            Debug.Log(44 + a);
        }
    }
}