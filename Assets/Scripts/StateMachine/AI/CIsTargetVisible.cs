using System.Collections;
using System.Collections.Generic;
using AI.BT;
using UnityEngine;

public class CIsTargetVisible : Behavior
{
    private AntController controller;

    public CIsTargetVisible(AntController controller)
    {
        this.controller = controller;
    }

    public override void OnInitialize()
    {
        base.OnInitialize();


    }

    public override Status Update()
    {

        Collider2D[] rayCheck = Physics2D.OverlapCircleAll(controller.transform.position, controller.radius, controller.targetLayer);
        if (rayCheck.Length > 0)
        {

            Transform target = rayCheck[0].transform;
            Vector2 directionToTarget = (target.position - controller.transform.position).normalized;

            if (Vector2.Angle(controller.transform.up, directionToTarget) < controller.angle / 2)
            {
                float distanceToTarget = Vector2.Distance(controller.transform.position, target.position);

                if (!Physics2D.Raycast(controller.transform.position, directionToTarget, distanceToTarget, controller.obstacleLayer) && controller._Agent.destination != target.gameObject.transform.position)
                {

                    controller._Agent.isStopped = true;
                    controller._Agent.ResetPath();
                    controller.targetFood = target.gameObject;

                    return Status.Success;
                }


            }

        }


        return Status.Running;
    }


}
