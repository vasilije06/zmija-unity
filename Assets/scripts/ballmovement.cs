using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public float ballForce = 20f;
    private Vector2 thurst;
    private Rigidbody2D rb;

    float /*speedX*/ speedY;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        //Debug.Log("LALLA");

    }

    // Update is called once per frame
    void Update()
    {
        // speedX = Input.GetAxisRaw("Horizontal") * playerForce * 0;
        speedY = Input.GetAxisRaw("Vertical") * playerForce;
        rb.velocity = new Vector2(0, speedY);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("Gore");



        }

    }
}
