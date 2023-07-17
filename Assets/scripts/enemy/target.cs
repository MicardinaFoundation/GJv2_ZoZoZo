using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float heatlh = 50f;

    public void TakeDamage(float amount)
    {
        heatlh -= amount;
        if (heatlh <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Debug.Log("бЬнав!");
    }
}
