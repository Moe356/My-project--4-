using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moe : MonoBehaviour
{
    void Start()
    {
        int randomNumber = Random.Range(1,21);
        int counter = 0;
        while(counter > 10)
        {
            Debug.Log(randomNumber);
            counter++;
            if(randomNumber == 5)continue;
           else if (randomNumber == 15) break;
        }
    }

}
