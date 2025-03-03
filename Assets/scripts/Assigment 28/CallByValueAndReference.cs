using UnityEngine;

namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        void Start()
        {
            int a = 5;
            int b = 10;
            int c;

            Debug.Log("Initial value of a: " + a);
            ModifyByValue(a);
            Debug.Log("Value of a after ModifyByValue: " + a);

            Debug.Log("\nInitial value of b: " + b);
            ModifyByReference(ref b);
            Debug.Log("Value of b after ModifyByReference: " + b);

            AssignUsingOut(out c);
            Debug.Log("\nValue of c after AssignUsingOut: " + c);
        }

        void ModifyByValue(int num)
        {
            num += 10;
            Debug.Log("Inside ModifyByValue, num: " + num);
        }

        void ModifyByReference(ref int num)
        {
            num += 10;
            Debug.Log("Inside ModifyByReference, num: " + num);
        }

        void AssignUsingOut(out int num)
        {
            num = 20;
            Debug.Log("Inside AssignUsingOut, num: " + num);
        }
    }
}
