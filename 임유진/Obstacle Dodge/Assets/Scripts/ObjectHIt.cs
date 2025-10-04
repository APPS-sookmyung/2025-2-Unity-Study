using UnityEngine;

public class ObjectHIt : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        // 플레이어에게 부딪히면 색 및 태그 변화
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
    
    }
}
