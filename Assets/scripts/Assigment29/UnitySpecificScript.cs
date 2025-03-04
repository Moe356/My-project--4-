using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        public GameObject targetObject; 
        void OnEnable()
        {
            print("GameObject Enabled");
        }

        void OnDisable()
        {
            print("GameObject Disabled");
        }

        void Start()
        {
            print("Game started!");

            // Finding objects
            if (targetObject == null)
                targetObject = GameObject.Find("TargetObject");

            print(targetObject ? $"Found object by name: {targetObject.name}" : "No TargetObject found.");

            var joker = GameObject.FindGameObjectWithTag("Joker");
            print(joker ? $"Found object by tag: {joker.name}" : "No Joker object found.");

            var light = GameObject.FindObjectOfType<Light>();
            print(light ? $"Found object of type Light: {light.name}" : "No Light object found.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {

                if (targetObject != null)
                {
                    targetObject.SetActive(false);
                    print("TargetObject deactivated!");
                }
                else
                {
                    print("TargetObject is null!");
                }
            }
        }
    }
}
