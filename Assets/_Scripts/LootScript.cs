using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootScript : MonoBehaviour
{
    public GameManager gm;

    public GameObject[] loot;
    public float currentLootTime = 0f;
    public float maxLootTime = 3f;
    public float increaseTimer = 0.1f;
    public int maxNumLoot;
    public float variance;
    bool looting;
    bool collided = false;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && collided == false)
        {
            collided = true;
            Debug.Log("Collided is true");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player" && collided == true)
        {
            collided = false;
            Debug.Log("Collided is false");
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q) && collided) //Arbitrary set to Q for testing
        {
            if (currentLootTime <= maxLootTime) //If timer under max, increase it
            {
                currentLootTime += increaseTimer;
                Debug.Log(currentLootTime);
            }
            if (currentLootTime >= maxLootTime && looting == false) //If timer over max, spawn loot
            {
                GetLoot();
                looting = true;
            }
        }
    }

    private void GetLoot() //Spawn loot
    {
        int randLoot = Random.Range(1, maxNumLoot);
        for (int i = 0; i < randLoot; i++) //Repeat for numLoot you want to spawn
        {
            int rand = Random.Range(0, loot.Length); //Pick a random game object in the array
            Vector3 offset = new Vector3(Random.Range(-variance, variance), Random.Range(-variance, variance), 0f);
            Instantiate(loot[rand], transform.position + offset, Quaternion.identity); //Spawn it
            Debug.Log("Spawned " + i + "of " + maxNumLoot);
        }
        gm.SpawnCorpse();
        Destroy(gameObject); //Get rid of the corpse
    }
}
