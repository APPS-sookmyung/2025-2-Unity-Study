using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX; 
    [SerializeField] int hitPoints = 3;
<<<<<<< HEAD
    [SerializeField] int scoreValue = 10;

    Scoreboard scoreboard;

    private void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }
=======
>>>>>>> 4dd90dc92f53410534ab9e18b9989472d2d3513e

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
<<<<<<< HEAD
            scoreboard.IncreaseScore(scoreValue);
=======
>>>>>>> 4dd90dc92f53410534ab9e18b9989472d2d3513e
            Instantiate(destroyedVFX, transform.position, Quaternion.identity); // Quaternion.identity: (0,0,0), no default rotation
            Destroy(this.gameObject);
        }
    }
}
