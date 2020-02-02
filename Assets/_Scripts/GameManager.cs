using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] enemySpawnPoints;
    public GameObject[] corpses;
    public Transform[] corpseSpawnPoints;
    public GameObject player;
    public int score;
    public int points = 100;
    public int health;
    public int corpseCounter;
    public int spawnRate;
    public PickupScript ps;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        ps = player.GetComponent<PickupScript>();
        score = 0;
        corpseCounter = spawnRate;
        SpawnCorpse();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CompleteObject(GameObject match)
    {
        Destroy(ps.held);
        ps.held = null;
        Destroy(match);
        score += points;
    }

    public void DecreaseHealth()
    {
        Debug.Log("Get shit on!");
        health--;
        if(health <= 0)
        {
            Debug.Log("I died");
        }
    }

    public void SpawnCorpse()
    {
        int randc = Random.Range(0, corpses.Length);
        int randCS = Random.Range(0, corpseSpawnPoints.Length);
        Instantiate(corpses[randc], corpseSpawnPoints[randCS].position, Quaternion.identity);
        corpseCounter++;
        if(corpseCounter >= spawnRate)
        {
            int randESP = Random.Range(0, enemySpawnPoints.Length);
            Instantiate(enemy, enemySpawnPoints[randESP].position, Quaternion.identity);
            corpseCounter = 0;
        }
    }
}
