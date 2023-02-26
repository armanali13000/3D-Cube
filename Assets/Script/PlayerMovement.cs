using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    
    // reference to Rigibody component calles "rb"
    public Rigidbody rb;
    public float forwardForce = 8000f;
    public float sidewayForce = 120f;
    // void Start()
    // {
    //     // rb.useGravity = false;
    //     rb.AddForce(0, 200, 500);        
    // }

    // Update is called once per frame
    // void Update()
    // {
    //     rb.AddForce(0, 0, 200);
    // }

    void FixedUpdate() //using it to mess with physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a forward force

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
