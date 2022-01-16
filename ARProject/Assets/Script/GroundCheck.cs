﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private int num;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SimpleSampleCharacterControl character = FindObjectOfType<SimpleSampleCharacterControl>();
            character.currentGround = num;
        }
    }
}
