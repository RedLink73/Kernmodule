using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int health;
    public int nrOfHearts;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;

    public void Update()
    {

        if(health > nrOfHearts)
        {
            health = nrOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHearts;
            }
            else
            {
                hearts[i].sprite = emptyHearts;
            }



            if (i < nrOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;

            }

            
        }

       
    }

    public void Damage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Application.Quit();
            Debug.Log("Quit!");
        }
    }
}
