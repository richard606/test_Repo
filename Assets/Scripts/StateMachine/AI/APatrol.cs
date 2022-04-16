using System.Collections;
using System.Collections.Generic;
using AI.BT;
using UnityEngine;

public class APatrol : Behavior
{
    private int index;

    private AntController controller;



    public APatrol(AntController controller)
    {
        this.controller = controller;
    }

    public override void OnInitialize()
    {

    }



    public override Status Update()
    {

        if (!controller._Agent.pathPending
             && controller._Agent.remainingDistance <= 0f)
        {

            float x = Random.Range(0.05f, 0.95f);
            float y = Random.Range(0.05f, 0.95f);
            Vector3 pos = new Vector3(x, y, 10.0f);
            pos = Camera.main.ViewportToWorldPoint(pos);
            controller._Agent.destination = pos;

        }


        return Status.Running;

    }


}