using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] Vector3 moveDirection;

    public static int cubesCount;

    public Rigidbody pRB;
    public Rigidbody p2RB;
    public Rigidbody cubeRB;
    private GameObject p;
    private GameObject p2;
    private GameObject cube;

    private bool movingLeft;
    private bool movingRight;
    private bool movingUp;
    private bool movingDown;

    void Start()
    {
        p = GameObject.FindWithTag("Player");
        p2 = GameObject.FindWithTag("Player2");
        cube = GameObject.FindWithTag("Cube");
        pRB = p.GetComponent<Rigidbody>();
        p2RB = p2.GetComponent<Rigidbody>();
        cubeRB = cube.GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        if (Input.GetKey(keyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
            Debug.Log(moveDirection);
        }
        if (Input.GetKey(keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
            Debug.Log(moveDirection);
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene($"Lvl2");
        }

        if (movingLeft) cubeRB.velocity += moveDirection;

        if (movingRight) cubeRB.velocity -= moveDirection;

        if (movingUp)
        {
            pRB.velocity -= moveDirection;
            p2RB.velocity -= moveDirection;
        }

        if (movingDown)
        {
            pRB.velocity += moveDirection;
            p2RB.velocity += moveDirection;
        }

    }

    public void MoveLeft()
    {
        movingLeft = true;
    }

    public void MoveRight()
    {
        movingRight = true;
    }

    public void MoveUp()
    {
        movingUp = true;
    }

    public void MoveDown()
    {
        movingDown = true;
    }

    public void StopMoveLeft()
    {
        movingLeft = false;
    }

    public void StopMoveRight()
    {
        movingRight = false;
    }

    public void StopMoveUp()
    {
        movingUp =false;
    }

    public void StopMoveDown()
    {
        movingDown = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            cubesCount++;
        }

        if (this.CompareTag("Player2") && other.CompareTag("Finish"))
        {
            cubesCount++;
        }

        if (cubesCount == 2)
        {
            cubesCount = 0;
            SceneManager.LoadScene($"Lvl2");
        }
    }

}