using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject human ;
    public void delete()
    {
        human = GameObject.Find("human");
        Destroy(human);
    }
}
