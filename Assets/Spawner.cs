using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject pinPreFab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") )
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPreFab, transform.position, transform.rotation);
    }
}
