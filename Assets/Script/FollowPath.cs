using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField] private float moveSpeed = 1f;

    [HideInInspector] 
    public int waypointIndex = 0;
    
    [HideInInspector] 
    public bool moveAllowed = false;

    //use this for inizialitation
    private void Start () 
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }
    

    // Update is called once per frame
    private void Update()
    {
        if (moveAllowed)
            Move();
    }


    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed = Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }


}
