using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIManager>();
            }

            return _instance;
        }
    }
    
    public Text scoreText;

    public GameObject gamePanel;
    public GameObject gameOverPanel;

    //We update the on screen displayed score over here
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gamePanel.SetActive(false);
        gameOverPanel.SetActive(true);
    }

}
