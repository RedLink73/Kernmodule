using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int maxHP = 1;
    public int cHP;

    public void Start()
    {
        cHP = maxHP;
    }

    public void DealDamage(int amount)
    {
        cHP -= amount;
        if (cHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
