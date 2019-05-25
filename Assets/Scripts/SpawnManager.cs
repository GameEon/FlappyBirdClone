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

public class SpawnManager : MonoBehaviour
{
    public GameObject pipesPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2, 2);
    }

    // SpawnPipes at 2 second intervals
    void SpawnPipes()
    {
        //Only spawn if game is not over
        if(!GameManager.Instance.gameOver)
            Instantiate(pipesPrefab, new Vector3(pipesPrefab.transform.position.x, pipesPrefab.transform.position.y + Random.Range(-2.5f,2.5f), pipesPrefab.transform.position.z), Quaternion.identity);
    }
}
