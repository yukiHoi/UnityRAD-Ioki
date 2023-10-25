using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControler : MonoBehaviour
{
    Animator zombieAnimator;


    // Start is called before the first frame update
    void Start()
    {
        zombieAnimator = GetComponent<Animator>();
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
