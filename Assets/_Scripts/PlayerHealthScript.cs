using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    void Start()
    {
        playerHealth = 6;
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

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("GameSceneMain", LoadSceneMode.Single);

        yield return null;
    }
}