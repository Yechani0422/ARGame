using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCast_Dragon : MonoBehaviour
{
    Animator anim;
    public int atkPnt = 1000;
    public int hItPnt = 5000;
    float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
        Debug.DrawRay(transform.position, forward, Color.green);

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            Debug.Log("로봇을 발견!");
            anim.SetBool("isHit", true);
            timeElapsed += Time.deltaTime;
            if (timeElapsed >= 0.5)
            {               
                hit.transform.GetComponent<rayCast_Robot>().hItPnt -= atkPnt;
                timeElapsed = 0f;
            }
        }
        else
        {
            anim.SetBool("isHit", false);
        }

        if (hItPnt <= 0)
        {
            anim.SetBool("isDead", true);
        }
    }
}
