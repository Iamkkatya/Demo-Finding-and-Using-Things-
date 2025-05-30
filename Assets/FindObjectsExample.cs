using UnityEngine;

public class FindObjectsExample : MonoBehaviour
{
    public GameObject myObject;

    void Start()
    {
        GameObject foundByName = GameObject.Find("Player");
        if (foundByName != null)
        {
            Debug.Log("Found object by name: " + foundByName.name);
        }
        else
        {
            Debug.Log("Object with this name not found!");
        }

        GameObject foundByTag = GameObject.FindWithTag("TargetObject");
        if (foundByTag != null)
        {
            Debug.Log("Found object by tag: " + foundByTag.name);
        }
        else
        {
            Debug.Log("Object with this tag not found!");
        }

        MeshRenderer foundComponent = GameObject.Find("Player").GetComponent<MeshRenderer>();
        if (foundComponent != null)
        {
            Debug.Log("MeshRenderer found!");
        }
        else
        {
            Debug.Log("MeshRenderer not found!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered the trigger: " + other.name);
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 10f))
        {
            Debug.Log("Raycast found: " + hit.collider.gameObject.name);
        }
    }
}
