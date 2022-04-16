using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ManagerFood : MonoBehaviour
{
    [SerializeField] GameObject food;
    List<GameObject> lst_Food = new List<GameObject>();

    int maxFoodIntances;

    void Start()
    {
        InvokeRepeating("GenerateFood", 4, 0.5f);
    }

    private void GenerateFood()
    {
        maxFoodIntances = GameManager.instance.GetAmoundAnt() * 3;
        if (lst_Food.Count < maxFoodIntances)
        {
            float x = Random.Range(0.05f, 0.95f);
            float y = Random.Range(0.05f, 0.95f);
            Vector3 pos = new Vector3(x, y, 10.0f);
            pos = Camera.main.ViewportToWorldPoint(pos);

            GameObject food = Instantiate(this.food, pos, Quaternion.identity);
            lst_Food.Add(food);
        }

    }

    //TODO metodo para remover la referencia de comida, o desactivarla y reutilizarla 
    public void RemoveFood(Food food)
    {

        lst_Food.Remove(food.gameObject);



    }

}
