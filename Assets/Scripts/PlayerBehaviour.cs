using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Key a;
    public Key b;
    public float forceSpeed = 100f;
    public float sideSpeed = 100f;
    void Start()
    {
       
    }

   
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forceSpeed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce( sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange );

        }

        if (rb.position.y < 1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
