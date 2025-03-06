using UnityEngine;

public class BoxControl : MonoBehaviour
{
    public GameObject lid;
    public float openSpeed = 5f;
    private bool isOpen = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            isOpen = !isOpen;
        }

        if (isOpen)
        {
            lid.transform.Rotate(Vector3.right * openSpeed * Time.deltaTime);
        }
        else
        {
            lid.transform.Rotate(Vector3.left * openSpeed * Time.deltaTime);
        }
    }
}
