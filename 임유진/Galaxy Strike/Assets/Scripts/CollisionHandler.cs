using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX; 

<<<<<<< HEAD
    GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        gameSceneManager.ReloadLevel();

=======
    private void OnTriggerEnter(Collider other)
    {
>>>>>>> 4dd90dc92f53410534ab9e18b9989472d2d3513e
        // Debug.Log("Hit " + other.name);
        // Debug.Log($"Hit {other.gameObject.name}");

        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
