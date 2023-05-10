using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camira : MonoBehaviour
{
    public float FollowSpeed = 2f;
    //public float yOffset = 1f;
    public Transform target;

// c a m i r a m o v e
    void Update()
    {
        // increase speed of player that main camira start to move
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
        
    }
}
