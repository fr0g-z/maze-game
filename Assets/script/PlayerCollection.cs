using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //only destroy if collectable
        if (other.CompareTag("Collectable"))

        {
            Destroy(other.gameObject);
        }

    }
}
