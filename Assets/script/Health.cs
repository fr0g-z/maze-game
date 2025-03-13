using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int points = 5;
    public Vector3 respawnPosition;
    public TMP_Text healthText;
    public GameObject gameOverScreen;

    private void Start()
    {
        respawnPosition = transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("trap"))
        {
            Damage(1);
        }
        if (other.CompareTag("checkpoint"))
        {
            respawnPosition = transform.position;
            // to respawn in the middle use this:
            //respawnPosition = other.transform.position;
            //respawnPosition.y = transform.position.y;     - this is to respawn on the top instead of directly in the middle
        }
    }
    //to remove health points
    private void Damage(int value)
    {
       
        points = points - value;
        healthText.text = $"<b>health:</b> {points}";
        //dollar sign is used for cominging things in a bracket


        transform.position = respawnPosition;

        // points = 5;

        if (points < 1)
        {
           gameOverScreen.SetActive(true);
            
            Destroy(gameObject);
           
        }
    }
}
