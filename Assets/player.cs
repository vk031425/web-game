using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, 1));
        }
         if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, -1));
        }
         if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-1, 0));
        }
         if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(1, 0));
        }
    }
}
