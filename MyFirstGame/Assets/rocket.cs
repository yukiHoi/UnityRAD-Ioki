using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float thrust = 10f;
    public Rigidbody rockerRigidbody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            LaunchRocket();
        }
    }
    void LaunchRocket()
    { 
        transform.position = Vector3.up* Time.deltaTime;
    }
}
