using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture12
{
    public class UnderstandingMonoBehavior : MonoBehaviour
    {
        // void Awake()
        // {
        //     Debug.Log("I am Mr.Awake()");

        // }
        int counter = 0;

        void Start()
        {
            Vector3 pos = new Vector3(1f, 1f, 1f);
            Vector3 rot = new Vector3(45, 0, 0);
            Vector3 scal = new Vector3(2, 1, 1);
            // Debug.Log(pos);
            // Debug.Log(rot);
            // Debug.Log(scal);

            // Debug.Log(Vector3.zero);
            // Debug.Log(Vector3.one);
            Debug.Log(Vector3.up);
            Debug.Log(Vector3.down);
            Debug.Log(Vector3.right);
            Debug.Log(Vector3.left);
            Debug.Log(Vector3.forward);
            Debug.Log(Vector3.back);
        }
    }
}