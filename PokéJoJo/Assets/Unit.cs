using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    public string unitName;
    public int unitLevel;

    public float damage;

    public float maxHP;
    public float currentHP;

    public float defense;

    private void Start()
    {
        currentHP = maxHP;
    }

    public bool TakeDamage(float damageAmount)
    {
        currentHP -= damageAmount - defense;

        if (currentHP <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Guard(float defenseMoltiplier)
    {
        defense *= defenseMoltiplier;
    }
}
