using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeController : MonoBehaviour
{
    [SerializeField] private LayerMask antLayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 3f, antLayer);
        if (colliders.Length > 0)
        {


            foreach (Collider2D ant in colliders)
            {
                //Debes crear por fin el FSM de la Hormiga Siuuuuu
                if (ant.GetComponent<AntController>().BringFood(out Food food))
                {

                    GameManager.instance.AddMoreFood(food.amount);
                    GameManager.instance.RemoveFoodInstance(food);
                    ant.GetComponent<AntController>().food = null;


                }
            }





        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 3f);
    }
}
