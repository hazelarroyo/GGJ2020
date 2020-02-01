using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGameScript : MonoBehaviour
{
    public void SceneChange(string Scene)
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
}