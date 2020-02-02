using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{
    public GameManager gm;
    bool collided = false;
    public PickupScript ps;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        ps = GameObject.FindGameObjectWithTag("Player").GetComponent<PickupScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && collided == true) //Arbitrary set to E for testing
        {
            //Pickup item
            if (ps.held == null)
            {
                ps.held = gameObject;
                ps.Hold();
            }
        }
        else if (Input.GetKeyDown(KeyCode.R) && collided == false)
        {
            //Drop item
            if(ps.held != null)
            {
                ps.Drop();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && collided == false)
        {
            collided = true;
            Debug.Log("Collided is true");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" && collided == true)
        {
            collided = false;
            Debug.Log("Collided is false");
        }
    }

    //Press a button to pick up or drop
    //Find a way to store the picked up object, and then check what it is
    //If collide while holding correct object, trigger CompleteObject()
}
