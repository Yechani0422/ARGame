using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private Image keyImage;

    [SerializeField]
    private Text text;

    [SerializeField]
    private Text claertext;

    [SerializeField]
    private GameObject nextBtn;

    [HideInInspector]
    public bool getKey = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        text.enabled = false;
        claertext.enabled = false;
        nextBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
        if(getKey==false)
        {
            keyImage.enabled = false;
        }
        else
        {
            keyImage.enabled = true;
        }        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"&&getKey ==false)
        {
            text.enabled = true;
        }

        if(other.gameObject.tag=="Player"&&getKey==true)
        {
            anim.SetBool("IsOpen", true);
            claertext.enabled = true;
            nextBtn.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && getKey == false)
        {
            text.enabled = false;
        }
    }
}
