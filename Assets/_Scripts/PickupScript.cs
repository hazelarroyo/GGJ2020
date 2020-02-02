using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    public GameObject held;
    public Transform storePoint;
    public GameManager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update()
    {
        if(held != null)
        {
            held.transform.position = storePoint.transform.position;
        }
    }

    public void Hold()
    {
        held.transform.position = storePoint.transform.position;
        held.transform.parent = gameObject.transform;
        held.GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    public void Drop()
    {
        held.transform.parent = null;
        held.GetComponent<Rigidbody2D>().gravityScale = 2.9f;
        held = null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(held != null)
        {
            if (collision.tag == held.tag)
            {
                gm.CompleteObject(collision.gameObject);
                Debug.Log("Collided is true");
            }
        }
    }

}
