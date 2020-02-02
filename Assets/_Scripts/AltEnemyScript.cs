using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltEnemyScript : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject player;

    public Transform target;

    public float speed = 1.5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        target = player.transform;
    }

    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine("Destroy");
        }
    }

    IEnumerator Destroy()
    {
        Vector2 byebye = new Vector2(Random.Range(-50, 50), Random.Range(-50, 50) * speed);
        rb.AddForce(byebye);

        yield return new WaitForSeconds(1.5f);

        Destroy(gameObject);

        yield return null;
    }
}
