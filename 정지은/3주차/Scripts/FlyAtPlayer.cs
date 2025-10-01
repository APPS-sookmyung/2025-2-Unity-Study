using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        // gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer(){
        // MoveTowards(현재위치, 목표위치, 속도) ; 플레이어가 있는 곳으로 1 유닛씩 이동
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime*speed);
    }

    void DestroyWhenReached(){
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}