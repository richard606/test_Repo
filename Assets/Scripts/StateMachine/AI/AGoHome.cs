using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI.BT;

public class AGoHome : Behavior
{
    private int index;

    private AntController controller;


    public AGoHome(AntController controller)
    {
        this.controller = controller;
    }
    public override void OnInitialize()
    {
        base.OnInitialize();
        controller._Agent.destination = controller.homeT.position;

    }
    public override void OnTerminate(Status status)
    {
        base.OnTerminate(status);

    }
    public override Status Update()
    {

        if (!controller._Agent.pathPending
            && controller._Agent.remainingDistance <= 2f)
        {

            controller._Agent.ResetPath();
            controller.foodGrabGO.gameObject.SetActive(false);
            return Status.Success;

        }

        return Status.Running;
    }









}
