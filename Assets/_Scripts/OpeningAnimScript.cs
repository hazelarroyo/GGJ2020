using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningAnimScript : MonoBehaviour
{
    public Animator anim;
    public Animator playerAnim;

    public GameObject player;
    public GameObject exCorpse;
    public GameObject arrow;
    public GameObject axePiece;
    public GameObject swordPiece;
    public GameObject arrowB;
    public GameObject arrowC;
    public GameObject arrowD;
    public GameObject arrowE;
    public GameObject arrowF;
    public GameObject finalText;

    REALPlayerMove playerMove;

    void Start()
    {
        playerMove = player.GetComponent<REALPlayerMove>();

        StartCoroutine("OpeningAnim");
    }

    void Update()
    {
        
    }

    IEnumerator OpeningAnim()
    {
        playerMove.enabled = false;

        yield return new WaitForSeconds(11);

        playerAnim.Play("leftrightdemo");

        yield return new WaitForSeconds(9);

        playerAnim.Play("jumpdemo");

        yield return new WaitForSeconds(2.1f);

        playerAnim.gameObject.SetActive(false);
        playerAnim.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        playerAnim.Play("jumpdemo");

        yield return new WaitForSeconds(5);

        exCorpse.SetActive(true);

        yield return new WaitForSeconds(1);

        arrow.SetActive(true);

        yield return new WaitForSeconds(0.3f);

        arrow.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        arrow.SetActive(true);

        yield return new WaitForSeconds(0.3f);

        arrow.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        arrow.SetActive(true);

        yield return new WaitForSeconds(0.3f);

        arrow.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        arrow.SetActive(true);

        yield return new WaitForSeconds(4);

        arrow.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        axePiece.SetActive(true);
        swordPiece.SetActive(true);

        yield return new WaitForSeconds(1);

        arrowB.SetActive(true);
        arrowC.SetActive(true);

        yield return new WaitForSeconds(0.3f);

        arrowB.SetActive(false);
        arrowC.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        arrowB.SetActive(true);
        arrowC.SetActive(true);

        yield return new WaitForSeconds(0.3f);

        arrowB.SetActive(false);
        arrowC.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        arrowB.SetActive(true);
        arrowC.SetActive(true);

        yield return new WaitForSeconds(0.3f);

        arrowB.SetActive(false);
        arrowC.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        arrowB.SetActive(true);
        arrowC.SetActive(true);

        yield return new WaitForSeconds(14);

        arrowB.SetActive(false);
        arrowC.SetActive(false);
        axePiece.SetActive(false);
        swordPiece.SetActive(false);
        exCorpse.SetActive(false);

        yield return new WaitForSeconds(3);

        arrowD.SetActive(true);

        yield return new WaitForSeconds(5);

        arrowD.SetActive(false);

        yield return new WaitForSeconds(3);

        arrowE.SetActive(true);

        yield return new WaitForSeconds(3);

        arrowE.SetActive(false);

        yield return new WaitForSeconds(2);

        arrowF.SetActive(true);

        yield return new WaitForSeconds(11);

        arrowF.SetActive(false);

        yield return new WaitForSeconds(2);

        playerAnim.gameObject.SetActive(false);
        playerAnim.gameObject.SetActive(true);

        yield return new WaitForSeconds(14);

        playerMove.enabled = true;
        finalText.SetActive(false);

        yield return null;
    }
}
