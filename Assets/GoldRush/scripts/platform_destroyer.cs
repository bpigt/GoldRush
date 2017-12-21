using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_destroyer : MonoBehaviour {
    Transform plat_destroyer;
    // Use this for initialization
	void Start () {
        plat_destroyer = GameObject.Find("track_destroyer").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(transform.position.z < plat_destroyer.position.z)
        {
            gameObject.SetActive(false);
        }
	}
}
