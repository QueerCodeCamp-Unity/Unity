using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void EndButton()
    {
        Application.Quit();
    }
}
