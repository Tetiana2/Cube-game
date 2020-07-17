
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerBehaviour movement;
 
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
        
    }
    
}
