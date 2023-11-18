using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;
    public bool isGameOver = false;
    public GameObject player;

    public void AddScore(int scorePoint)
    {
        score += scorePoint;
    }
    void Start()
    {
        AddScore(1);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0;
        Debug.Log("GAME OVER!");
    }



}