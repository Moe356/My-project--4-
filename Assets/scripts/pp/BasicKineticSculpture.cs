using UnityEngine;

public class BasicKineticSculpture : MonoBehaviour
{
    public int sphereCount = 4;
    public float bounceHeight = 1f;
    public float rotationSpeed = 20f;
    
    private GameObject rotatingCube;
    private GameObject[] spheres;

    void Start()
    {
        // Create rotating cube at the center
        rotatingCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        rotatingCube.transform.position = Vector3.zero;
        rotatingCube.transform.localScale = new Vector3(2f, 2f, 2f);

        // Create spheres around the cube
        spheres = new GameObject[sphereCount];
        for (int i = 0; i < sphereCount; i++)
        {
            float xOffset = (i - sphereCount / 2) * 2f;
            spheres[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            spheres[i].transform.position = new Vector3(xOffset, 2f, 0);
        }
    }

    void Update()
    {
        // Rotate the cube
        rotatingCube.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Make spheres bounce up and down
        for (int i = 0; i < sphereCount; i++)
        {
            Vector3 pos = spheres[i].transform.position;
            pos.y = 2f + Mathf.Sin(Time.time) * bounceHeight;
            spheres[i].transform.position = pos;
        }
    }
}