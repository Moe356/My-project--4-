using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Warrior : ICanFight
    {
        public void Attack() => Debug.Log("Warrior attacks with a sword!");
    }
