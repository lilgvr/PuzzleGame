using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartNewGameScript : MonoBehaviour
{
    // Frames
    public GameObject start;

    // Buttons
    public GameObject continueButton;

    public void continueButtonTap()
    {
        start.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
