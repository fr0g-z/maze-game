using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform target;
    public float transitionSpeed = 10;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //calculates how far the camera is from the player
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // where the camera should go
        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, transitionSpeed * Time.deltaTime);
    }
}
