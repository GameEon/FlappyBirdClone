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
 
public class Pipes : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public int killPositionX = -10;
    Transform selfTransform;
    // Start is called before the first frame update
    void Start()
    {
        selfTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Instance.gameOver)
            selfTransform.position -= new Vector3(moveSpeed, 0);
        if(selfTransform.position.x < killPositionX)
        {
            Destroy(gameObject);
        }
    }
}
