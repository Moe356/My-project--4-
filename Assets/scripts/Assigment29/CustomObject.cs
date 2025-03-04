using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class CustomObject
    {
        public int ID { get; }
        public string Name { get; }

        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }
    }
