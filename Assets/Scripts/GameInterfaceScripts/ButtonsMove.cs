using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsMove : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveUp()
    {
        GetComponent<Rigidbody>().velocity += moveDirection;
    }
}
