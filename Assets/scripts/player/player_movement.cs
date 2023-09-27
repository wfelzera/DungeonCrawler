using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float xvel;
    public float yvel;

    void Start()
    {
        xvel = 0;
        yvel = 0;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.S) && yvel > -0.02f) yvel -= this.GetComponent<stats>().speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W) && yvel < 0.02f) yvel += this.GetComponent<stats>().speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A) && xvel > -0.02f) xvel -= this.GetComponent<stats>().speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D) && xvel < 0.02f) xvel += this.GetComponent<stats>().speed * Time.deltaTime;

        Transform trans = this.transform;
        trans.position += new Vector3(xvel, yvel);

        if (xvel > 0) {
            if (xvel - 0.15f * Time.deltaTime < 0) xvel = 0;
            else xvel -= 0.15f * Time.deltaTime; 
        }
        if (xvel < 0)
        {
            if (xvel + 0.15f * Time.deltaTime > 0) xvel = 0;
            else xvel += 0.15f * Time.deltaTime;
        }
        if (yvel > 0)
        {
            if (yvel - 0.15f * Time.deltaTime < 0) yvel = 0;
            else yvel -= 0.15f * Time.deltaTime;
        }
        if (yvel < 0)
        {
            if (yvel + 0.15f * Time.deltaTime > 0) yvel = 0;
            else yvel += 0.15f * Time.deltaTime;
        }


        if(Input.GetKeyDown(KeyCode.E)) this.GetComponent<stats>().health -= 1;
        if (Input.GetKeyDown(KeyCode.Q)) this.GetComponent<stats>().health += 1;
    }
}
