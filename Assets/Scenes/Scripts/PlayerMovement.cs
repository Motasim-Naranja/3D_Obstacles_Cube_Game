
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce=5000f;
    public float SidewayForce=500f;

    
    void FixedUpdate()
    {
        
            
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
         if (Input.GetKey("d"))
            { 
                rb.AddForce(SidewayForce * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange); 
                
            }
          else if (Input.GetKey("a")) 
            { 
                rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0 ,ForceMode.VelocityChange); 
            }
        if (rb.position.y < -1f) 
            {
                FindObjectOfType<GameManager>().EndGame();
            }
    }
}
