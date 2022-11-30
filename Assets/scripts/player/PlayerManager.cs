using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject StartingText;

    public static int numberofcoins;
    public Text CoinsText;

    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        isGameStarted = false;
        numberofcoins = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        CoinsText.text = "Coins:" + numberofcoins;
        if(SwipeManager.tap && !isGameStarted)
        {
            isGameStarted = true;
            Destroy(StartingText);
        }
        
    }
}
