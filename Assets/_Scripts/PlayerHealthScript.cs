using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    int playerHealth;

    public Image heartA;
    public Image halfHeartA;
    public Image empHeartA;
    public Image heartB;
    public Image halfHeartB;
    public Image empHeartB;
    public Image heartC;
    public Image halfHeartC;
    public Image empHeartC;

    public Animator anim;

    Animator charanim;

    Vector2 startPosition;

    void Start()
    {
        playerHealth = 6;

        startPosition = transform.position;

        charanim = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerHealth <= 5)
        {
            heartA.enabled = false;
        }

        if (playerHealth <= 4)
        {
            halfHeartA.enabled = false;
        }

        if (playerHealth <= 3)
        {
            heartB.enabled = false;
        }

        if (playerHealth <= 2)
        {
            halfHeartB.enabled = false;
        }

        if (playerHealth <= 1)
        {
            heartC.enabled = false;
        }

        if (playerHealth == 0)
        {
            halfHeartC.enabled = false;
            StartCoroutine("Loser");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 1;
        }
    }

    IEnumerator Loser()
    {
        anim.Play("lose");
        playerHealth = 6;

        yield return new WaitForSeconds(3);

        gameObject.transform.position = startPosition;
        charanim.SetTrigger("idle");

        heartA.enabled = true;
        halfHeartA.enabled = true;
        heartB.enabled = true;
        halfHeartB.enabled = true;
        heartC.enabled = true;
        halfHeartC.enabled = true;

        yield return new WaitForSeconds(7);

        anim.gameObject.SetActive(false);
        anim.gameObject.SetActive(true);

        yield return null;
    }
}