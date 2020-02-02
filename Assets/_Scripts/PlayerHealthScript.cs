using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    int playerHealth;

    public Image heartA;
    public Image halfHeartA;
    public Image heartB;
    public Image halfHeartB;
    public Image heartC;
    public Image halfHeartC;

    void Start()
    {
<<<<<<< HEAD
        playerHealth = 6;
=======

>>>>>>> e90d3cda13c825e098a68ac1d163e36c9dcad7f2
    }

    void Update()
    {
<<<<<<< HEAD
        if(playerHealth <= 5)
        {
            heartA.enabled = false;
        }
=======

>>>>>>> e90d3cda13c825e098a68ac1d163e36c9dcad7f2
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< HEAD
        if(collision.gameObject.name == "Enemy")
=======
        if (collision.gameObject.CompareTag("Enemy"))
>>>>>>> e90d3cda13c825e098a68ac1d163e36c9dcad7f2
        {
            playerHealth -= 1;
        }
    }
}