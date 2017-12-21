using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {


    public float speed;
    public Camera cam_main;
    public Vector3 left_point;
    public Vector3 right_point;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

     //   Debug.Log(cam_main.transform.eulerAngles);

       // transform.RotateAroundLocal()
        //transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y,cam_main.transform.rotation.z, 1);
        transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y,-cam_main.transform.eulerAngles.z);
      //  transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, cam_main.transform.localEulerAngles.z));
	}
}
