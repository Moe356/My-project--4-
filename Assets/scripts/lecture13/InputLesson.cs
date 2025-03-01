using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLesson : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))//left button
        {
            Debug.Log("Mouse Left Button");
        }
        if (Input.GetMouseButtonUp(1))//Right button
        {
            Debug.Log("Mouse Middle Button");
        }
        if (Input.GetMouseButtonUp(2))//Middle button
        {
            Debug.Log("Mouse Right Button");
        }
        if (Input.mouseScrollDelta.y != 0)//Mouse Wheel scrolling
        {
            Debug.Log("Mouse scrolling Occured : " + Input.mouseScrollDelta.y);
        }
    }
}
