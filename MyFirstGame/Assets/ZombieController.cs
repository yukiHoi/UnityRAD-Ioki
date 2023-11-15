using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    cube player;
    Animator zombieAnimator;
    enum ZombieState { Idle, Attack, Follow, Dying }
    ZombieState currentlyIs = ZombieState.Idle;
    private float aggroRadius = 10;
    private float walkingSpeed = 0.3f;
    private float meleeDistance = 1;


    // Start is called before the first frame update
    void Start()
    {
        zombieAnimator = GetComponent<Animator>();
        player = FindObjectOfType<cube>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentlyIs)
        {
            case ZombieState.Idle:

                if (Vector3.Distance(player.transform.position, transform.position) < aggroRadius)
                {
                    currentlyIs = ZombieState.Follow;
                    zombieAnimator.SetBool("IsWalking", true);


                }
                break;

            case ZombieState.Attack:


                break;

            case ZombieState.Follow:
                transform.LookAt(player.transform.position);
                transform.position += transform.forward * walkingSpeed * Time.deltaTime;

                if (Vector3.Distance(player.transform.position, transform.position) < meleeDistance)
                {
                    currentlyIs = ZombieState.Attack;
                }
                break;

            case ZombieState.Dying:
                break;

        }
        }
    internal void dieNow()
    {
        zombieAnimator.SetBool("isDying", true);
        Destroy(gameObject,5);
        currentlyIs = ZombieState.Dying;
    }
    }
