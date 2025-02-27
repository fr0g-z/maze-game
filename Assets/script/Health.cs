using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trap"))
        {
            Damage(1);
        }
        
    }
    //to remove health points
    private void Damage(int value)
    {
        points = points - value;
        if (points < 1)
        {
            //homework 
            // do not destroy move the player tp start and reset points to 5

            Destroy(gameObject);
        }
    }
}
