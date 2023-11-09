using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieManager : MonoBehaviour

    
{
    public Transform zombieCloneTemplate;
    int numberOfZombie = 100;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = new Vector3(
            Random.Range(-50f, 50f),
            -7.26f,
             Random.Range(-50f, 50f));

        for (int i = 0; i < numberOfZombie; i++)
            Instantiate(zombieCloneTemplate);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
