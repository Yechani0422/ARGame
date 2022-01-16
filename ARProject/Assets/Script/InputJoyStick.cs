using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputJoyStick : MonoBehaviour
{
    public FixedJoystick moveJoyStick;
    public SimpleSampleCharacterControl control;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        control.Hinput = moveJoyStick.Horizontal;
        control.Vinput = moveJoyStick.Vertical;
    }
}
