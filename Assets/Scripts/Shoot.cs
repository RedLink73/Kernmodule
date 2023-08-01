using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform ShootingPoint;

    public GameObject BulletPrefabA;
   

    Vector2 lookDirection;
    float lookAngle;

    public float ForceBullet = 20f;
    public GameObject player;



    // Update is called once per frame
    void Update()

    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - new Vector3(player.transform.position.x, player.transform.position.y);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        ShootingPoint.rotation = Quaternion.Euler(0, 0, lookAngle);


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootingA();
        }

    }

    void ShootingA()
    {
      
        GameObject bullet = Instantiate(BulletPrefabA);
        bullet.GetComponent<BulletInfo>().BulletType = 1;
        bullet.transform.position = ShootingPoint.transform.position;
        bullet.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
        bullet.GetComponent<Rigidbody2D>().velocity = ShootingPoint.right * ForceBullet;

    }

}
