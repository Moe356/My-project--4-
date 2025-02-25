using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lecture11{
public class ChildClass : BaseClass
    {
        public override void printInfo()
        {
            // base.printInfo();
            Debug.Log("I am the poor Sabi !!");
        }
    }
}

namespace Lecture11_5
{
    using Lecture11;

    public class ChildClass
    {
        Lecture11.ChildClass cc = new Lecture11.ChildClass();
//without using Lecture11.ChildClass u will  not use the childclass in namespace 11 and u will use the one which is in lecture in namespace 11_5
        public void printInfo2()
        {
            // base.printInfo();
            Debug.Log("I am the poor Sabi from the next Neighborhood!!");
        }

        public void printCC()
        {
            cc.printInfo();
        }
    }
}
