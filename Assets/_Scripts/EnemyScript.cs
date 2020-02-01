using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    public float speed = 3f;
    public float slow = 2f;
    private Rigidbody2D rb;
    public int minDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(target.position, transform.position) < minDistance)
        {
            rb.AddForce((target.position - transform.position) * speed);
        } else
        {
            rb.AddForce((target.position - transform.position) * speed / slow);
        }
        
    }
}
