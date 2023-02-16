using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonStart : MonoBehaviour
{
    public void StartScreen()
    {
        SceneManager.LoadScene("Level - 1");
    }
}
