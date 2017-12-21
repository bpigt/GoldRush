
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour {

    public GameObject trolley;
    Vector3 offset;
	// Use this for initialization
	void Start () {

        offset = trolley.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = trolley.transform.position - offset;
        //left rotaion
        //Debug.Log(transform.eulerAngles.z);
        //if (transform.rotation.z > 320)
        //{
        //   transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, Mathf.Clamp(transform.eulerAngles.z, 320, 360));

        //      }
        

        if (transform.eulerAngles.z>0 && transform.eulerAngles.z < 180)
           transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.x, Mathf.Clamp(transform.eulerAngles.z, 1, 25));
       if(transform.eulerAngles.z >  180 && transform.eulerAngles.z<360)
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.x, Mathf.Clamp(transform.eulerAngles.z, 335, 360));

    }
}
