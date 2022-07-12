using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    public GameObject hobj;
    public GameObject cobj;

    void start(){

    }
    public void onclick()
    {
        GameObject dhobj = null;
        GameObject dcobj = null;

        dhobj = GameObject.Find("human");
        dcobj = GameObject.Find("Cube");
        Debug.Log(dhobj);
        Debug.Log(dcobj);

        if (dhobj == null)
        {
            Destroy(dcobj);
            GameObject human = Instantiate (hobj, new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);
            human.name = hobj.name;
        }
        else //if (dcobj == null)
        {
            Destroy(dhobj);
            GameObject cube = Instantiate (cobj, new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);
            cube.name = cobj.name;
        }
    }
    void update(){

    }
} 
