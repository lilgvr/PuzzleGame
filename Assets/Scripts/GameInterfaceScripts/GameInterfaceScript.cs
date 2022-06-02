using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameInterfaceScript : MonoBehaviour
{
    // Frames
    public GameObject interfaceFrame;
    public GameObject removeAds;

    // Buttons
    public GameObject menuButton;
    public GameObject removeAdsButton;
    public GameObject changeSoundButton;
    public GameObject restartLevelButton;

    public Sprite soundOnSprite, soundOffSprite;
    private bool isSoundOn = true;


    public void MenuButtonTap()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RemoveAdsButtonTap()
    {
        interfaceFrame.SetActive(false);
        removeAds.SetActive(true);
    }

    public void ChangeSoundButtonTap()
    {
        if (isSoundOn) {
            changeSoundButton.GetComponent<Image>().sprite = soundOffSprite;
            isSoundOn = false;
        }
        else
        {
            changeSoundButton.GetComponent<Image>().sprite = soundOnSprite;
            isSoundOn = true;
        }
    }

    public void RestartLevelButtonTap()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
