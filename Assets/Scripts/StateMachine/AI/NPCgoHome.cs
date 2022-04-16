using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCgoHome :INPCState
{
    public INPCState DoState(NPCSearch_ClassBased npc)
    {
        SetDestinationHome(npc);
        Debug.Log("Hola");
        if (Distance(npc.transform.position, npc.home.position) > 0.2f)
        {

            return npc.nPCgoHome;
        }
        
        
        return npc.nPCfindleaf;

    }

    private void SetDestinationHome(NPCSearch_ClassBased npc)
    {
               
        Vector3 dir = npc.home.position - npc.transform.position;
        Vector3 dirNormalized = dir.normalized;
        npc.transform.up += dirNormalized;
        npc.transform.position += dirNormalized*5 * Time.deltaTime;

    }

    public float Distance(Vector3 point1, Vector3 point2)
    {

        return Mathf.Sqrt(Mathf.Pow((point2.x - point1.x), 2) + Mathf.Pow((point2.y - point1.y), 2) + Mathf.Pow((point2.z - point1.z), 2));

    }


}
