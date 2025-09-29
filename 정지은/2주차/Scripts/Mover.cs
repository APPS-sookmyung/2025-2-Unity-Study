using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Start() // 호출되거나 그 자리에서 실행됨
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move using WASD or Arrow Keys");
        Debug.Log("Don't bump into objects!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; // x축으로 이동하는 값
        float yValue = 0f; // y축으로 이동하는 값
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed; // z축으로 이동하는 값
        transform.Translate(xValue, yValue, zValue); // 각 축으로 이동
    }
}