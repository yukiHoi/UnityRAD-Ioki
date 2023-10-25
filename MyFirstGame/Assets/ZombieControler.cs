using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    Animator zombieAnimator;
 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    
        if (Input.GetKey(KeyCode.Space))
            zombieAnimator.SetBool("IsWalking", true);
        else
            zombieAnimator.SetBool("IsWalking", false);
    }
}
