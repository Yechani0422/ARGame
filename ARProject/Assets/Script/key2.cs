using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key2 : MonoBehaviour
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
        if (other.gameObject.tag == "Player")
        {
            Door2 door = FindObjectOfType<Door2>();
            door.getKey = true;
            Destroy(gameObject);
        }
    }
}
