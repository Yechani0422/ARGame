using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Door door = FindObjectOfType<Door>();
            door.getKey = true;
            Destroy(gameObject);
        }
    }
}
