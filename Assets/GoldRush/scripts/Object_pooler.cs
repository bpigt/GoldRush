using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_pooler : MonoBehaviour {


    List<GameObject> objlist;
    public int poolLength;
    public GameObject track;
   

    // Use this for initialization

    void Start()
    {

        objlist = new List<GameObject>();
        
        for (int i = 0; i < poolLength; i++)
        {
            objlist.Add(Instantiate(track));
            objlist[i].SetActive(false);
        }

    }
    public GameObject createtrack()
    {
        for (int i = 0; i < objlist.Count; i++)
        {
           
            if (!objlist[i].activeInHierarchy)
            {

                // Debug.Log("in stack"+platform_stack.Peek());
                return objlist[i];
            }

        }
        GameObject obj = Instantiate(track);
        objlist.Add(obj);
        return obj;

    }
}
