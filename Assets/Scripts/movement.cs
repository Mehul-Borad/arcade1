using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rbplayer;
    public float sidevel;
    public float jumpvel;
    bool pressed = false;
    public bool touch = false;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d")&&touch) {
            rbplayer.velocity = new Vector2(sidevel*10*Time.fixedDeltaTime,0);
            pressed = true;
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            if (Input.GetKey("w"))
            {
                rbplayer.velocity += new Vector2(0, jumpvel * 10 * Time.fixedDeltaTime);
            }
        }
        
        else if (Input.GetKey("a") && touch)
        {
            rbplayer.velocity = new Vector2(-sidevel * 10 * Time.fixedDeltaTime, 0);
            pressed = true;
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z); if (Input.GetKey("w"))
            {
                rbplayer.velocity += new Vector2(0, jumpvel * 10 * Time.fixedDeltaTime);
            }
        }
        else if (Input.GetKey("w") && touch)
        {
            rbplayer.velocity = new Vector2(0, jumpvel * 10 * Time.fixedDeltaTime);
            pressed = true;
        }
        else if(pressed&&touch)
        {
            rbplayer.velocity = new Vector2(0,0);
            pressed = false;
        }
        
    }
   
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "background")
        {
            touch = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "background")
        {
            touch = true;
        }
        if (collision.collider.tag == "Enemy")
        {

        }
    }
}
