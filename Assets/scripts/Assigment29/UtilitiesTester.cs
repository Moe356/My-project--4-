using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class UtilitiesTester : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Utilities.Add(1, 2, 3, 4));
            Debug.Log("Hello".RepeatString(3));
        }
    }
