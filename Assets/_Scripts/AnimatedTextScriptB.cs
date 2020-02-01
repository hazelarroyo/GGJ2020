using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedTextScriptB : MonoBehaviour
{
    Text txt;
    string story;

    public Text prevText;
    public Text nextText;

    void Awake()
    {
        txt = GetComponent<Text>();
        story = txt.text;
        txt.text = "";

        StartCoroutine("PlayText");
    }

    IEnumerator PlayText()
    {
        foreach (char c in story)
        {
            txt.text += c;
            yield return new WaitForSeconds(0.08f);
        }

        yield return new WaitForSeconds(2f);

        nextText.gameObject.SetActive(true);
        prevText.gameObject.SetActive(false);

        yield return null;
    }
}