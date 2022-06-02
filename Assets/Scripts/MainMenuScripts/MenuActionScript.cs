using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuActionScript : MonoBehaviour
{
    // Frames
    public GameObject mainMenu;
    public GameObject pickLevel;
    public GameObject removeAds;
    public GameObject exit;

    // Buttons
    public GameObject resumeButton;
    public GameObject pickLevelButton;
    public GameObject removeAdsButton;
    public GameObject exitButton;


    public void ResumeButtonTap()
    {
        mainMenu.SetActive(false);
        SceneManager.LoadScene($"LvL1");
    }

    public void PickLevelButtonTap()
    {
        pickLevel.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void RemoveAdsButtonTap()
    {
        removeAds.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void ExitButtonTap()
    {
        exit.SetActive(true);
        mainMenu.SetActive(false);
    }
}
