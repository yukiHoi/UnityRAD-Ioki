using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.J))
            transform.position += transform.forward * Time.deltaTime;
    }
}
