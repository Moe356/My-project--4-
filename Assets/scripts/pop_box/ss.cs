// using UnityEngine;

// public class BoxControl : MonoBehaviour
// {
//     public GameObject lid;  // Assign the lid GameObject in the Inspector
//     public float openSpeed = 50f;  // Speed of rotation
//     private bool isOpen = false;
//     private float openAngle = -90f;  // Target open angle
//     private float closedAngle = 0f;  // Target closed angle

//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0))  // Click to toggle
//         {
//             isOpen = !isOpen;
//         }

//         // Get the current X rotation
//         float currentAngle = lid.transform.localEulerAngles.x;

//         // Convert angle to proper range (-180 to 180)
//         if (currentAngle > 180) currentAngle -= 360;

//         if (isOpen)
//         {
//             // Rotate only if not fully open
//             if (currentAngle > openAngle)
//             {
//                 lid.transform.Rotate(Vector3.right * -openSpeed * Time.deltaTime);
//             }
//         }
//         else
//         {
//             // Rotate only if not fully closed
//             if (currentAngle < closedAngle)
//             {
//                 lid.transform.Rotate(Vector3.right * openSpeed * Time.deltaTime);
//             }
//         }
//     }
// }
