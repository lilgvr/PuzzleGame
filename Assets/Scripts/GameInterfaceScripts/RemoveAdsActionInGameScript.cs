using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveAdsActionInGameScript : MonoBehaviour
{
    // Frames
    public GameObject game;
    public GameObject initialRemoveAds;
    public GameObject finalRemoveAds;


    // Buttons
    public GameObject acceptPurchaseButton;
    public GameObject cancelButton;
    public GameObject returnToGameButton;


    public void AcceptPurchaseButtonTap()
    {
        finalRemoveAds.SetActive(true);
        initialRemoveAds.SetActive(false);
    }

    public void CancelButtonTap()
    {
        game.SetActive(true);
        initialRemoveAds.SetActive(false);
    }

    public void ReturnToGameButtonTap()
    {
        game.SetActive(true);
        finalRemoveAds.SetActive(false);
    }
}
