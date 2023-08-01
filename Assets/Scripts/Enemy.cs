using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public Transform player;

    public float shotsStart;
    private float betweenShotsTime;

    public GameObject projctile;
    



    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        betweenShotsTime = shotsStart;

    }

    public void Update()
    {
        if(Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        } else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance) {

            transform.position = this.transform.position;

        } else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed *  Time.deltaTime);
        }


        if (betweenShotsTime <= 0)
        {
            Instantiate(projctile, transform.position, Quaternion.identity);
            betweenShotsTime = shotsStart;

        }
        else
        {
            betweenShotsTime -= Time.deltaTime;
        }
        
        
    }
}







