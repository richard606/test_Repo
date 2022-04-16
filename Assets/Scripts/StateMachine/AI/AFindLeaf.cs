using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AI.BT;

public class AFindLeaf : Behavior
{
    private int index;

    private AntController controller;


    public AFindLeaf(AntController controller)
    {
        this.controller = controller;
    }

    public override void OnInitialize()
    {
        base.OnInitialize();
        controller._Agent.destination = controller.targetFood.transform.position;
    }

    public override Status Update()
    {

        if (!controller.targetFood.activeInHierarchy)
        {
            return Status.Aborted;
        }
        if (!controller._Agent.pathPending
             && controller._Agent.remainingDistance <= 2f)
        {
            controller.food = controller.targetFood.GetComponent<Food>();
            controller.targetFood.SetActive(false);

            controller.foodGrabGO.gameObject.SetActive(true);
            return Status.Success;

        }


        return Status.Running;
    }


}
