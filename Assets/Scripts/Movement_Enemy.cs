using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Enemy : MonoBehaviour
{
    public float move_time;
    public float speed;
    float time=0;
    public Rigidbody2D rb;
    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        if (time <= move_time&&rb.velocity.x<=0)
        {
            rb.velocity = new Vector2(speed*Time.fixedDeltaTime, rb.velocity.y);
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        if (time> move_time&&rb.velocity.x>=0)
        {
            rb.velocity = new Vector2(-speed * Time.fixedDeltaTime, rb.velocity.y);
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        if (time > move_time * 2)
        {
            time = 0;
        }
    }
}
