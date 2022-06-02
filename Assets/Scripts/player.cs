﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField]KeyCode keyTwo;
    [SerializeField] Vector3 moveDirectoin;

    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirectoin;
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirectoin;
        }
        if (Input.GetKey(KeyCode.R))
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }   

    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player")&& other.CompareTag("Finish")) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        }
    
}
