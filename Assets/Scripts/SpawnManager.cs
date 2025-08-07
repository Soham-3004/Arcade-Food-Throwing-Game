using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabAnimals;      //["Dog_Beagle_01", "Animal_Horse_Brown", "Animal_Fox_02"]
    private float spawnRangeX = 20f;
    private float spwanZ = 30f;
    private float startDelay = 2f;
    private float spawnInterval = 2f;
    public bool gameOver = false;
    public TextMeshProUGUI loseText;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);   
    }

    // Update is called once per frame
    void Update()
    {
        RestartGame();
    }

    void SpawnRandomAnimal()
    {
        int anmialIndex = Random.Range(0, prefabAnimals.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spwanZ);
        Instantiate(prefabAnimals[anmialIndex], spawnPos, prefabAnimals[anmialIndex].transform.rotation);
    }

    private void RestartGame()
    {
        if (gameOver)
        {
            loseText.gameObject.SetActive(true);
            StartCoroutine(Restart());
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(5);
        loseText.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
