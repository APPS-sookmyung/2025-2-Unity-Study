using UnityEngine;

public class Mover : MonoBehaviour
{
    float xValue = 0.01f; // x축으로 이동하는 값
    float yValue = 0.05f; // y축으로 이동하는 값
    float zValue = 0f; // z축으로 이동하는 값


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() // 호출되거나 그 자리에서 실행됨
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue, yValue, zValue); // 각 축으로 이동
    }
}
