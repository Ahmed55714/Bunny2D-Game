using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class bee : MonoBehaviour
{
   public AIPath aiPath;

   //s c a l e  f o r   e n e m y
    
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.1f) {

             transform.localScale = new Vector3(5f, 5f, 5f);
        }
        else if (aiPath.desiredVelocity.x <= 0.1f) {
            transform.localScale = new Vector3(5f, 5f, 5f);
        }
    }
}
