using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float xvel;
    public float yvel;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        xvel = Input.GetAxisRaw("Horizontal") * GetComponent<stats>().speed;
        yvel = Input.GetAxisRaw("Vertical") * GetComponent<stats>().speed;
        rb.velocity = new Vector2 (xvel, yvel);

        if(Input.GetKeyDown(KeyCode.E)) this.GetComponent<stats>().health -= 1;
        if (Input.GetKeyDown(KeyCode.Q)) this.GetComponent<stats>().health += 1;
    }
}
