using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            Animal animal = new Cat();
            animal.MakeSound();
            animal.Move();

            if (animal is Cat cat)
            {
                cat.MakeSound();
                cat.Move();
            }

            var fighters = new List<ICanFight> { new Cat(), new Warrior() };
            foreach (var fighter in fighters)
            {
                fighter.Attack();
                Debug.Log(fighter is Cat ? "The object is a Cat." : "The object is a Warrior.");
            }
        }
    }