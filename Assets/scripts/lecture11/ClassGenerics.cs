using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;
namespace Lecture11
{
    public class ClassGenerics<T>
    {
        public T val;
        public ClassGenerics(T val)
        {
            this.val = val;
        }
        public void printV()
        {
            Debug.Log(val);
        }
    }
}