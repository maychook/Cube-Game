using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public CharacterMovement movement;

    private void OnCollisionEnter(Collision CollisionInfo)
    {
        
        if (CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //Debug.Log("oops");
        }
    }
}
