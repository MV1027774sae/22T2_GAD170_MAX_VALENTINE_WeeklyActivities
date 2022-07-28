using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public int maxMana = 1000;
    public int currentMana;

    public void Start()
    {
        Reset();
        AdjustHealth(195);
    }
    public void Reset()
    {
        currentHealth = maxHealth;
        currentMana = maxMana;
    }

    public void AdjustHealth(int value)
    {
        currentHealth += value;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else if(currentHealth <=0)
        {
            //Character has no health left
            Debug.Log("Ow");
        }
    }
}
