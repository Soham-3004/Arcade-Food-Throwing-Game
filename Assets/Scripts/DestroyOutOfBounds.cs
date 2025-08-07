using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float UpperBounds = 30f;
    private float lowerBound = -10f;
    private SpawnManager spawnManager;

    void Start()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > UpperBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            spawnManager.gameOver = true;
            Destroy(gameObject);
        }
    }
}
