using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;
    public float damageAmount;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void Damage()
    {
        currentHealth = currentHealth - damageAmount;
    }
}
