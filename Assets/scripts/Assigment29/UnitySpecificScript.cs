using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class UnitySpecificScript : MonoBehaviour
    {
        void OnEnable() => print("GameObject Enabled");
        void OnDisable() => print("GameObject Disabled");
        void Start()
        {
            print("Game started!");
            var target = GameObject.Find("TargetObject");
            print(target ? $"Found object by name: {target.name}" : "No TargetObject found.");
            var joker = GameObject.FindGameObjectWithTag("Joker");
            print(joker ? $"Found object by tag: {joker.name}" : "No Joker object found.");
            var light = GameObject.FindObjectOfType<Light>();
            print(light ? $"Found object of type Light: {light.name}" : "No Light object found.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                var target = GameObject.Find("TargetObject");
                if (target)
                {
                    target.SetActive(false);
                    print("TargetObject deactivated!");
                }
            }
        }
    }
