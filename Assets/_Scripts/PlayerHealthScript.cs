﻿using System.Collections;
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
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 1;
        }
    }
}