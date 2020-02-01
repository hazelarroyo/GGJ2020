using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroAnimationScript : MonoBehaviour
{
    public Animator anim;

    public Text lastText;

    void Awake()
    {
        StartCoroutine("IntroAnims");
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator IntroAnims()
    {
        yield return new WaitForSeconds(27);

        anim.Play("castle");

        yield return new WaitForSeconds(26);

        anim.Play("shopkeep");

        yield return new WaitForSeconds(30);

        anim.Play("title");

        yield return null;
    }
}
