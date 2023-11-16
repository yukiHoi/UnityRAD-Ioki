using System.Collections;
using System.Collections.Generic;
using UnityEditor.Sprites;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody rb;
    float kickStrength = 10;
    // Start is called before the first frame update
    void Awake()
    {
       
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void KickBall(Transform kicker)
    {
        rb.AddForce(kickStrength * kicker.forward, ForceMode.Impulse);
        rb.AddExplosionForce(kickStrength, kicker.position, 4);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        { print("Boing!!"); }
        else
        {
            ZombieController testZombie = collision.gameObject.GetComponent<ZombieController>();
            if (testZombie != null)
            {
             testZombie.dieNow();
            }
            
                print("Ouch");

            KickBall(collision.transform );
        }
    }
}
