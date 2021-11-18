using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class Score : MonoBehaviour
{
    private int score;
    private int highscore;
    private int lifepoint;
    public Text scoreText;
    public Text highscoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Fruit")
        {
            Destroy(GameObject.FindWithTag("Fruit"));
        }
    }
}
