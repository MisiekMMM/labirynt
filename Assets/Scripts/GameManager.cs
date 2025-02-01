using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    [SerializeField] int timeToEnd;
    bool isGamePaused = false;
    
    bool endGame = false;
    bool isWin = false;

    public int points = 0;

    public int redKey = 0;
    public int greenKey = 0;

    public int goldKey = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }

        if (timeToEnd <= 0)
        {
            timeToEnd = 10;
        }

        InvokeRepeating("Stopper", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        PauseCheck();
    }

    void Stopper()
    {
        timeToEnd--;
        Debug.Log("Time:" + timeToEnd + "s");

        if (timeToEnd <= 0)
        {
            timeToEnd = 0;
            endGame = true;

        }
        if (endGame)
        {
            EndGame();
        }
    }

    public void PauseGame()
    {
        Debug.Log("Pause game");
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void ResumeGame()
    {
        Debug.Log("Resume game");
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    void PauseCheck()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void EndGame()
    {
        CancelInvoke("Stopper");
        if (isWin)
        {
            Debug.Log("You win!👍🔥🔥🔥");
        }
        else
        {
            Debug.Log("You lose! 👎💀💀⏳");
        }
    }
    public void AddPoints(int value)
    {
        points += value;
    }
    public void AddTime(int value)
    {   
        timeToEnd += value;
    }
    public void FreezeTime(float time)
    {
        CancelInvoke("Stopper");
        InvokeRepeating("Stopper", time, 1);
    }
}
