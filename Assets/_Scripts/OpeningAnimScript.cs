using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningAnimScript : MonoBehaviour
{
    public Animator anim;

    REALPlayerMove playerMove;

    public GameObject player;

    void Start()
    {
        playerMove = player.GetComponent<REALPlayerMove>();

        StartCoroutine("OpeningAnims");
    }

    void Update()
    {
        
    }

    IEnumerator OpeningAnims()
    {
        playerMove.enabled = false;

        yield return null;
    }
}
