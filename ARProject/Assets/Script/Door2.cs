﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door2 : MonoBehaviour
{
    [HideInInspector]
    public bool getKey = false;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision other)
    {
        

        if (other.gameObject.tag == "Player" && getKey == true)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
       
    }
}
