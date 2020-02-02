using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //Press a button to pick up or drop
            //Find a way to store the picked up object, and then check what it is
            //If collide while holding correct object, trigger CompleteObject()
            Debug.Log("You got a point, bitch!");
            Destroy(gameObject);
        }
    }
}
