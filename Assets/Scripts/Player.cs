using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
100% mobile compatible
In case of any doubts feel free to mail me on nikhil.malankar@gmail.com
You can use this ready template for any of your projects
All the best!! 
:)

Author: Nikhil Malankar
www.gamedevnikhil.com
www.gameeon.in
www.nikmlnkr.com

Find me on instagram:
https://www.instagram.com/nikmlnkr

Find me on Twitter:
https://www.twitter.com/nikmlnkr

Find me on Facebook:
https://www.facebook.com/nikmlnkr
 */
 
public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public int jumpForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    //Make the bird jump
    public void Jump()
    {
        rigidbody.velocity = new Vector2(0, jumpForce);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "score")
        {
            GameManager.Instance.ScoreIncrement();
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "kill")
        {
            GameManager.Instance.GameOver();
        }
    }
}
