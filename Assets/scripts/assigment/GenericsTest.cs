using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> potionContainer = new GameContainer<string>();
        potionContainer.SetItem("Healing Potion");
        
        string storedItem = potionContainer.GetItem();
        Debug.Log("Stored item: " + storedItem);
        
        string description = GameUtils.DescribeItem(storedItem);
        Debug.Log(description);
    }
}