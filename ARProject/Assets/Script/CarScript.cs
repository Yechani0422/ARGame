using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    [SerializeField]
    public float carSpeed;
    [SerializeField]
    private float feelerLength;
    [SerializeField]
    private Transform startPos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * carSpeed * Time.deltaTime;
        Decelerate();

        if(transform.position.z>5||transform.position.z<-5)
        {
            transform.position = startPos.position;
            carSpeed = Random.Range(2.0f, 2.5f);
        }
    }

    void Decelerate()
    {
        Ray frontFeeler = new Ray(transform.position+new Vector3(0, 0.1f, 0), transform.forward);
        RaycastHit hit;
        
        if(Physics.Raycast(frontFeeler,out hit, feelerLength))
        {
            if(hit.collider.tag=="Car")
            {
               carSpeed= hit.collider.gameObject.GetComponent<CarScript>().carSpeed;
               // Debug.Log(hit.collider.gameObject.name);
            }

            if(hit.collider.tag=="Wall")
            {
                transform.position = startPos.position;
                carSpeed = Random.Range(2.0f, 2.5f);
            }
        }

        Debug.DrawRay(transform.position + new Vector3(0, 0.1f, 0), transform.forward * feelerLength, Color.green);
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag=="Car")
        {
            transform.position = startPos.position;
        }
    }
}
