using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public PlayableDirector timeline;
    public GameObject WinPanel;

    private int scoreCount  = 0;
    public int ScoreCount
    {
        get
        {
            return scoreCount;
        }
        set
        {
            scoreCount = value;
            UpdateScore();
        }
    }
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }


    public void UpdateScore()
    {
        scoreDisplay.text = "Twój Wynik: " + scoreCount.ToString();
        if (scoreCount == 4) 
        {
            Invoke("Win", 8f);
        }
    }

    public void StartLevel()
    {
        Invoke("StartDelayedLevel", 3f);
    }
    public void StartDelayedLevel()
    {
        timeline.Play();
    }

    public void Win()
    {
     
        WinPanel.SetActive(true);
    }
    

}
