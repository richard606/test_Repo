using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSearch_ClassBased : MonoBehaviour
{
    INPCState nPCState;

    public NPCfindLeaf nPCfindleaf = new NPCfindLeaf();
    public NPCgoHome nPCgoHome = new NPCgoHome();
    public NPCrunAway nPCrunAway = new NPCrunAway();

    public Queue<GameObject> lst_food = new Queue<GameObject>();


    public Transform home;

    void Start()
    {
        nPCState = nPCfindleaf;
    }

    // Update is called once per frame
    void Update()
    {
        if (nPCState != null) {
            nPCState = nPCState.DoState(this);
        }
       
    }
    
}
