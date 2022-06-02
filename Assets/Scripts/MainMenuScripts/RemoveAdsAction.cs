using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAdsAction : MonoBehaviour
{
    // Frames
    public GameObject mainMenu;
    public GameObject initialRemoveAds;
    public GameObject finalRemoveAds;


    // Buttons
    public GameObject acceptPurchaseButton;
    public GameObject cancelButton;
    public GameObject returnToMenuButton;


    public void AcceptPurchaseButtonTap()
    {
        finalRemoveAds.SetActive(true);
        initialRemoveAds.SetActive(false);
    }

    public void CancelButtonTap()
    {
        mainMenu.SetActive(true);
        initialRemoveAds.SetActive(false);
    }

    public void ReturnToMainMenuButtonTap()
    {
        mainMenu.SetActive(true);
        finalRemoveAds.SetActive(false);
    }
}
