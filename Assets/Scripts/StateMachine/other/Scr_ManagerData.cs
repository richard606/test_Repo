using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ManagerData : MonoBehaviour
{
    public GameObject home;

    void Start()
    {
       GameObject homeInstance = Instantiate(home); 
       homeInstance.transform.position = Camera.main.ViewportToWorldPoint(new Vector3(.95f,.50f,10.0f));
    }

  
}
