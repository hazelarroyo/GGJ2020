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

    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(target.position, transform.position) < minDistance)
        {
            rb.AddForce((target.position - transform.position) * speed);
        }
        else
        {
            rb.AddForce((target.position - transform.position) * speed / slow);
        }

        if (facingRight == false && rb.velocity.x > 0)
        {
            Flip();
        }
        else if (facingRight == true && rb.velocity.x < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
