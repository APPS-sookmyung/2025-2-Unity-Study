using UnityEngine;

public class ObjectHIt : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        Debug.Log("Something hit me!");
    }
}
