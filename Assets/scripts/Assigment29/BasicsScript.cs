using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var number = 5;
            var message = "Hello, Unity!";
            var isActive = true;

            Debug.Log($"The number {number} is odd");
            Debug.Log("Current Date: " + DateTime.Now.ToShortDateString());
            Debug.Log("Current Time: " + DateTime.Now.ToLongTimeString());
            Debug.Log("Current Day: " + DateTime.Now.DayOfWeek);
        }
    }
}