using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Updated is called fixed amount of times per
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(Input.GetAxisRaw("horizontal") * speed * Time.fixedDeltaTime, 0));
        rb.AddForce(new Vector2(Input.GetAxisRaw("vertical") * speed * Time.fixedDeltaTime, 0));
    }
}
