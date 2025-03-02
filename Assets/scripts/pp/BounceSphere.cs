using UnityEngine;

public class BounceSphere : MonoBehaviour
{
    public float bounceHeight = 2f; 
    public float bounceSpeed = 2f;  

    private float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        float newY = startY + Mathf.Sin(Time.time * bounceSpeed) * bounceHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
