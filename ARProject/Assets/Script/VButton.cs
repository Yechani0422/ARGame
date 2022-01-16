using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VButton : MonoBehaviour
{   
    public GameObject Dragon;
    public GameObject vbBtnObj;

    private VirtualButtonBehaviour[] virtualButtonBehaviours;
    // Start is called before the first frame update
    void Start()
    {

        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; ++i)
        {
            virtualButtonBehaviours[i].RegisterOnButtonPressed(OnButtonPressed);
            virtualButtonBehaviours[i].RegisterOnButtonReleased(OnButtonReleased);
        }

        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed:" + vb.VirtualButtonName);
        Dragon.GetComponent<Animator>().SetBool("isAttack", true);
    }
    
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased:" + vb.VirtualButtonName);
        Dragon.GetComponent<Animator>().SetBool("isAttack", false);
    }
}