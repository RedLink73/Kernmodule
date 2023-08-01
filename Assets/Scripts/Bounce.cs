using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Rigidbody2D rb;

    Vector3 lastVelocity;

    public void Start()
    {
        StartCoroutine(SelfDestruct());
    }
 

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        lastVelocity = rb.velocity;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      

        if (collision.gameObject.CompareTag("EnemyShield") || collision.gameObject.CompareTag("Walls"))
        {
            // if the tag is shield or other
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Min(speed, 100f);
        }

        else if (collision.gameObject.CompareTag("Player")){
           collision.gameObject.GetComponent<Health>().Damage(1);
           collision.gameObject.GetComponent<Hit>().FlashRedPlease();
           DestroyProjectile();
        }

        else if (collision.gameObject.CompareTag("Enemy"))
        {

            // lose HP
            collision.gameObject.GetComponent<EnemyHP>().DealDamage(1);
            collision.gameObject.GetComponent<Hit>().FlashRedPlease();
            DestroyProjectile();
        }


    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }

}
