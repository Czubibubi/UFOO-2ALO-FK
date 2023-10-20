using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOmovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public int force;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
        
            
    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * force);
    }

    private void OnTriggerEnter2D(Collider2D obiekt)
    {
        if (obiekt.gameObject.CompareTag("PIKAP"))
            Destroy(obiekt.gameObject);
    }
}
