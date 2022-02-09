using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCfindLeaf : INPCState
{
    public INPCState DoState(NPCSearch_ClassBased npc)
    {
        if (npc.lst_food.Count > 0) {

            GotoFood(npc);
            
            if (Distance(npc.transform.position, npc.lst_food.Peek().transform.position) > 0.7f)
            {
                return npc.nPCfindleaf;
            }
            else {
                npc.lst_food.Dequeue().SetActive(false);
                return npc.nPCgoHome;

            }


        }

        return npc.nPCfindleaf;
    }

    private void GotoFood(NPCSearch_ClassBased npc)
    {
        Vector3 dir = npc.lst_food.Peek().transform.position - npc.transform.position;
        Vector3 dirNormalized = dir.normalized;
        npc.transform.up += dirNormalized;
        npc.transform.position += dirNormalized* 4 * Time.deltaTime;
       
    }

    public float Distance(Vector3 point1, Vector3 point2) {

        return Mathf.Sqrt(Mathf.Pow((point2.x - point1.x),2) + Mathf.Pow((point2.y - point1.y), 2) + Mathf.Pow((point2.z - point1.z), 2));
    
    }

    
}
