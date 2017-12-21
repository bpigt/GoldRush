using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_gen_Scrpt : MonoBehaviour {

    public Transform platform_gen_point;
    public Object_pooler[] object_pooler_track;
    public Object_pooler object_pooler_tunnel;
    public float[] track_length;
  //  public GameObject track;
    public GameObject cave;
    float length;
    // Use this for initialization
    void Start () {
        track_length = new float[object_pooler_track.Length];

        for(int i = 0; i < object_pooler_track.Length; i++)
        {
            track_length[i] = object_pooler_track[i].track.GetComponent<BoxCollider>().size.z;
        }
    }


	// Update is called once per frame
	void Update () {
		if(transform.position.z < platform_gen_point.position.z)
        {
            //Instantiate(track, transform.position, transform.rotation);


            int rand = Random.Range(0,3);

            //Instantiate(cave, transform.position, transform.rotation);
            GameObject tunnel = object_pooler_tunnel.createtrack();
            tunnel.SetActive(true);
            tunnel.transform.position = transform.position;


            GameObject track = object_pooler_track[rand].createtrack();
            track.SetActive(true);
            track.transform.position = transform.position;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + track_length[rand]*10);
        }
	}
}
