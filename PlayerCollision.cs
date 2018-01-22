using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public Rigidbody rb;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            rb.useGravity = false;
            rb.drag = 1;
            rb.AddForce(0, 3, 2, ForceMode.VelocityChange);
            FindObjectOfType<GameManager>().endgame();
           
        }
    }
}
