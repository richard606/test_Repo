using System;
using System.Collections;
using System.Collections.Generic;
using AI.BT;
using UnityEngine;
using UnityEngine.AI;


public class AntController : MonoBehaviour
{


    //FOV variables
    public float radius = 5f;
    [Range(1, 100)] public float angle = 45;
    public LayerMask targetLayer;
    public LayerMask obstacleLayer;

    public GameObject targetFood;

    //end FOV variables


    //GoHome variables

    [SerializeField] public Transform homeT;



    //end GoHome variables


    internal bool BringFood(out Food amountFood)
    {
        amountFood = null;

        if (food != null)
        {
            amountFood = food;
            return true;

        }

        return false;

    }

    private NavMeshAgent agent;
    public NavMeshAgent _Agent
    {
        get
        {
            return agent;
        }
    }



    private Behavior root;

    public GameObject foodGrabGO;

    public Food food;
    public Queue<GameObject> lst_food = new Queue<GameObject>();
    // -------------------------------------------------------------
    private void Start()
    {
        InitializeVars();
    }

    // -------------------------------------------------------------
    private void InitializeVars()
    {

        agent = GetComponent<NavMeshAgent>();


        homeT = GameObject.Find("Home").GetComponent<Transform>();

        root = new Repeat(false, new Sequence(new Parallel(Parallel.Policy.RequireOne, Parallel.Policy.RequireAll,
             new CIsTargetVisible(this), new APatrol(this)),
            new AFindLeaf(this),
           new AGoHome(this)));








    }

    // -------------------------------------------------------------
    private void Update()
    {
        if (!root.IsTerminated())
        {
            root.Tick();
        }

    }


}
