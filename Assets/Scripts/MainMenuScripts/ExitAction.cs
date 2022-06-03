using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAction : MonoBehaviour
{
    // Frames
    public GameObject mainMenu;
    public GameObject exit;


    // Buttons
    public GameObject exitButton;
    public GameObject returnButton;


    public void exitButtonTap()
    {
        Application.Quit();
    }

    public void returnButtonTap()
    {
        mainMenu.SetActive(true);
        exit.SetActive(false);
    }
}
