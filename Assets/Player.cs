using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float jumpStrength;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Collider collider = collision.gameObject.GetComponent<Collider>();
        if (collider is not MeshCollider)
        {
            print("ur ded(((");
        }
        else
        {
            rb.AddRelativeForce(0,jumpStrength,0); 
        }
    }
    
}
