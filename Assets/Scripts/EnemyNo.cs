using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNo : MonoBehaviour
{
 
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public Transform EnemyNotHere;


    public void Start()
    {
        EnemyNotHere = GameObject.FindGameObjectWithTag("EnemyNotHere").transform;

    }

    public void Update()
    {
        //if (Vector2.Distance(transform.position, EnemyNotHere.position) > stoppingDistance)
        //{
        //    transform.position = Vector2.MoveTowards(transform.position, EnemyNotHere.position, speed * Time.deltaTime);

        //}
        //else if (Vector2.Distance(transform.position, EnemyNotHere.position) < stoppingDistance && Vector2.Distance(transform.position, EnemyNotHere.position) > retreatDistance)
        //{

        //    transform.position = this.transform.position;

        //}
        if (Vector2.Distance(transform.position, EnemyNotHere.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, EnemyNotHere.position, -speed * Time.deltaTime);
        }




    }
}
