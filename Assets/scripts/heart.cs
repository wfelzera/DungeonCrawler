using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public int number;
    float hp;

    void Start()
    {
        hp = GameObject.Find("player").GetComponent<stats>().health;
    }
    void Update()
    {
        hp = GameObject.Find("player").GetComponent<stats>().health;
        if (hp >= number && !this.GetComponent<SpriteRenderer>().enabled) this.GetComponent<SpriteRenderer>().enabled = true;
        else if (hp < number && this.GetComponent<SpriteRenderer>().enabled) this.GetComponent<SpriteRenderer>().enabled = false;
    }
}
