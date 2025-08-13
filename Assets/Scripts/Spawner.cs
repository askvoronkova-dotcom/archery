using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public int enemiesPerWave = 1;
    public float waveInterwal = 0f;
    private int currentWave = 0;
    private bool gameWon = false;
    private bool gameLoose = false;


    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    IEnumerator SpawnWaves()
    {
        while (currentWave < 5 && !gameWon && !gameLoose)
        {
            currentWave++;
            Debug.Log($"Wave {currentWave} started!");

            for (int i = 0; i < enemiesPerWave; i++)
            {
                Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                GameObject enemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
                Instantiate(enemy, spawnPoint.position, Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }

            yield return new WaitForSeconds(waveInterwal);
        }
        if (gameLoose == false)
        {
            gameWon = true;
            Debug.Log("You won");
        }
    }
    public void LoseGame()
    {
        gameLoose = true;;
    }
}
