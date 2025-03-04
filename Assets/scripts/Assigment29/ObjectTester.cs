using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class ObjectTester : MonoBehaviour
    {
        void Start()
        {
            var obj = new CustomObject(1, "Mahamad");
            print(obj);
        }
    }
