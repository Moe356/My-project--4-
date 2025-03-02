using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // Rotation speed in degrees per second
    public float rotationSpeed = 45f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the cube around the Y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
