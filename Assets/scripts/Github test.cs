using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Moe : MonoBehaviour
{
    void Start()
    {
         string funnySentence = "";

        int counter = 0;
        string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree" ,"Monkey", "Ball", "Bird"};
        while(counter < 7)
        {
            int randomWord= Random.Range(0,words.Length);
            
            counter++;
            funnySentence += words[randomWord] + " ";

        }
        Debug.Log(funnySentence);
    }

}
