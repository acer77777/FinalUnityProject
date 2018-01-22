using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float zspeed = 2000f;
    public float xspeed = 500f;
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, zspeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(xspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-xspeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y  < -1f)
        {
            FindObjectOfType<GameManager>().endgame();
        }
    }
}
