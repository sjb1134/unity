using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class move : MonoBehaviour
{
    public Rigidbody rb;
    public  float forwardForce = 1000f ; 
    public  float sidewayForce = 100f ;
    

    // Start is called before the first frame update
    void Start()
    {
    
     }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime );




        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime,0,0,ForceMode.VelocityChange );
        }


     }
}
