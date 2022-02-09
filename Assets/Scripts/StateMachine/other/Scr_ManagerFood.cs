using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ManagerFood : MonoBehaviour
{
    [SerializeField] GameObject food;
    NPCSearch_ClassBased ant;


    private void Awake()
    {
        ant = GameObject.Find("ant").GetComponent <NPCSearch_ClassBased>();

    }
    void Start()
    {
        InvokeRepeating("GenerateFood", 4, 2);
    }

    private void GenerateFood()
    {
        float x = Random.Range(0.05f, 0.95f);
        float y = Random.Range(0.05f, 0.95f);
        Vector3 pos = new Vector3(x, y, 10.0f);
        pos = Camera.main.ViewportToWorldPoint(pos);

        GameObject food= Instantiate(this.food, pos, Quaternion.identity);
        ant.lst_food.Enqueue(food);
    }

}
