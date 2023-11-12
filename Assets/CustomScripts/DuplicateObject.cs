using UnityEngine;
using NRKernal;

public class DuplicateObjectOnClick : MonoBehaviour
{
    public GameObject objectToDuplicate; // Reference to the GameObject you want to duplicate

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DuplicateObject();
        }
    }

    void DuplicateObject()
    {
        // Check if the object to duplicate is assigned
        if (objectToDuplicate != null)
        {
            // Instantiate a new instance of the object at the same position and rotation
            GameObject newObject = Instantiate(objectToDuplicate, transform.position, transform.rotation);

            // For example, change the color of the new object to red
            Renderer renderer = newObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.red;
            }
        }
        else
        {
            Debug.LogWarning("Object to duplicate is not assigned!");
        }
    }
}