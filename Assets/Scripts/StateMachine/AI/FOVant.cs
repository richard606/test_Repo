using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVant : MonoBehaviour
{
    public float radius = 5f;
    [Range(1, 100)] public float angle = 45;
    public LayerMask targetLayer;
    public LayerMask obstacleLayer;

    [SerializeField] AntController antController;

    public GameObject targetFood;
    void Start()
    {
        StartCoroutine(FOVCheck());

    }

    private IEnumerator FOVCheck()
    {
        WaitForSeconds wait = new WaitForSeconds(0.2f);

        while (true)
        {
            yield return wait;
            FOV();

        }
    }

    private void FOV()
    {
        Collider2D[] rayCheck = Physics2D.OverlapCircleAll(transform.position, radius, targetLayer);
        if (rayCheck.Length > 0)
        {

            Transform target = rayCheck[0].transform;
            Vector2 directionToTarget = (target.position - transform.position).normalized;

            if (Vector2.Angle(transform.up, directionToTarget) < angle / 2)
            {
                float distanceToTarget = Vector2.Distance(transform.position, target.position);

                if (!Physics2D.Raycast(transform.position, directionToTarget, distanceToTarget, obstacleLayer) && antController._Agent.destination != target.gameObject.transform.position)
                {
                    antController._Agent.isStopped = true;
                    antController._Agent.ResetPath();
                    targetFood = target.gameObject;
                    Debug.Log("Helow");
                }
                else
                {
                    // targetFood = null;
                }

            }
            else
            {
                //targetFood = null;
            }
        }
        else if (targetFood != null)
        {
            // targetFood = null;
        }

    }

   

    /*private Vector3 DirectionToAngle(float eulerY, float angleInDegress)
    {

    }*/
}
